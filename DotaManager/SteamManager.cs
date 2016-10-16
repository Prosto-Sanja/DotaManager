using System;
using DotaManager.Data_Classes.Enums;
using DotaManager.Data_Classes.Exceptions;
using SteamKit2;

namespace DotaManager
{
    internal class SteamManager
    {

        private readonly SteamClient _steamClient;
        private readonly CallbackManager _callbackManager;

        private readonly SteamUser _steamUser;
        private readonly SteamFriends _steamFriends;

        private SteamManagerStatus _isRunning = SteamManagerStatus.Stopped;

        private readonly string _user, _pass;

        private Exception _exception;

        public SteamManager(string user, string pass)
        {
            if (string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(pass))
            {
                //invalid login arguments, can't continue
                throw new InvalidCredentialsException("Username or password unspecified!");
            }

            _user = user;
            _pass = pass;

            // create our steamclient instance
            _steamClient = new SteamClient();
            // create the callback manager which will route callbacks to function calls
            _callbackManager = new CallbackManager(_steamClient);

            // get the steamuser handler, which is used for logging on after successfully connecting
            _steamUser = _steamClient.GetHandler<SteamUser>();
            // get the steam friends handler, which is used for interacting with friends on the network after logging on
            _steamFriends = _steamClient.GetHandler<SteamFriends>();

            // register a few callbacks we're interested in
            _callbackManager.Subscribe<SteamClient.ConnectedCallback>(OnConnected);
            _callbackManager.Subscribe<SteamClient.DisconnectedCallback>(OnDisconnected);

            _callbackManager.Subscribe<SteamUser.LoggedOnCallback>(OnLoggedOn);
            _callbackManager.Subscribe<SteamUser.LoggedOffCallback>(OnLoggedOff);
            _callbackManager.Subscribe<SteamUser.AccountInfoCallback>(OnAccountInfo);
        }

        private void OnConnected(SteamClient.ConnectedCallback callback)
        {
            if (callback.Result != EResult.OK)
            {
                _exception = new ConnectionException("Unable to connect to Steam: " + callback.Result.ToString());
                return;
            }
            //Connected to Steam! Logging in
            _isRunning = SteamManagerStatus.LoggingIn;
            _steamUser.LogOn(new SteamUser.LogOnDetails
            {
                Username = _user,
                Password = _pass,
            });
        }

        private void OnDisconnected(SteamClient.DisconnectedCallback callback)
        {
            //if we are shutting down - ok; if drop - throw
            if (_isRunning == SteamManagerStatus.Stopped) return;
            _exception = new ConnectionException("Disconnected from Steam");
        }

        private void OnLoggedOn(SteamUser.LoggedOnCallback callback)
        {
            if (callback.Result != EResult.OK)
            {
                _exception = new SteamLoginException("Unable to logon to Steam: " + callback.Result.ToString() + " /// " + callback.ExtendedResult.ToString());
                return;
            }
            _isRunning = SteamManagerStatus.Online;
            //Successfully logged in

        }

        private void OnLoggedOff(SteamUser.LoggedOffCallback callback)
        {
            //if we are shutting down - ok; if drop - throw
            if (_isRunning == SteamManagerStatus.Stopped) return;
            _exception = new SteamLoginException("Unexpectedly logged off");
        }

        private void OnAccountInfo(SteamUser.AccountInfoCallback callback)
        {
            // before being able to interact with friends, you must wait for the account info callback
            // this callback is posted shortly after a successful logon

            _steamFriends.SetPersonaState(EPersonaState.Busy);
        }


        public void Start()
        {
            _isRunning = SteamManagerStatus.Connecting;
            // initiate the connection
            _steamClient.Connect();
            // create our callback handling loop
            while (_isRunning != SteamManagerStatus.Stopped)
            {
                // in order for the callbacks to get routed, they need to be handled by the manager
                _callbackManager.RunWaitCallbacks(TimeSpan.FromSeconds(1));
            }
        }

        public SteamManagerStatus Monitor()
        {
            if (_exception != null)
            {
                Stop();
                throw _exception;
            }
            return _isRunning;
        }

        public void Stop()
        {
            _isRunning = SteamManagerStatus.Stopped;
            _steamClient.Disconnect();
        }

        public SteamClient SteamClient => _steamClient;
        public CallbackManager CallbackManager => _callbackManager;
    }
}
