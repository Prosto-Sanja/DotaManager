using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using DotaManager.Data_Classes.Enums;
using SteamKit2;
using SteamKit2.GC;
using SteamKit2.GC.Dota.Internal;

namespace DotaManager.Dota_Operations.Forms
{
    public partial class CreateLobbyForm : Form
    {

        private readonly SteamGameCoordinator _steamGameCoordinator;

        public CreateLobbyForm(SteamGameCoordinator steamGameCoordinator)
        {
            _steamGameCoordinator = steamGameCoordinator;
            InitializeComponent();
        }

        private void CreateLobbyForm_Load(object sender, EventArgs e)
        {
            gmodeBox.ValueMember = "Value";
            gmodeBox.DisplayMember = "Description";
            gmodeBox.DataSource = Enum.GetValues(typeof(DotaGameModes))
                .Cast<Enum>()
                .Select(value => new
                {
                    (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()), typeof(DescriptionAttribute)) as DescriptionAttribute)?.Description, value
                })
                .OrderBy(item => item.Description)
                .ToList();

            serverBox.ValueMember = "Value";
            serverBox.DisplayMember = "Description";
            serverBox.DataSource = Enum.GetValues(typeof(DotaServerRegions))
                .Cast<Enum>()
                .Select(value => new
                {
                    (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()), typeof(DescriptionAttribute)) as DescriptionAttribute)?.Description,
                    value
                })
                .OrderBy(item => item.Description)
                .ToList();

            penaltyRadiantBox.ValueMember = "Value";
            penaltyRadiantBox.DisplayMember = "Description";
            penaltyRadiantBox.DataSource = Enum.GetValues(typeof(DotaDraftPenalty))
                .Cast<Enum>()
                .Select(value => new
                {
                    (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()), typeof(DescriptionAttribute)) as DescriptionAttribute)?.Description,
                    value
                })
                .OrderBy(item => item.value)
                .ToList();
            penaltyRadiantBox.Text = "Radiant";
            penaltyDireBox.ValueMember = "Value";
            penaltyDireBox.DisplayMember = "Description";
            penaltyDireBox.DataSource = Enum.GetValues(typeof(DotaDraftPenalty))
                .Cast<Enum>()
                .Select(value => new
                {
                    (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()), typeof(DescriptionAttribute)) as DescriptionAttribute)?.Description,
                    value
                })
                .OrderBy(item => item.value)
                .ToList();
            penaltyDireBox.Text = "Dire";
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            var leavelobby = new ClientGCMsgProtobuf<CMsgPracticeLobbyLeave>((uint)EDOTAGCMsg.k_EMsgGCPracticeLobbyLeave);
            _steamGameCoordinator.Send(leavelobby, 570);

            var createLobby = new ClientGCMsgProtobuf<CMsgPracticeLobbyCreate>((uint)EDOTAGCMsg.k_EMsgGCPracticeLobbyCreate);
            createLobby.Body.lobby_details = new CMsgPracticeLobbySetDetails();
            createLobby.Body.lobby_details.game_name = nameBox.Text;
            createLobby.Body.lobby_details.pass_key = passBox.Text;
            createLobby.Body.lobby_details.server_region = (uint)(DotaServerRegions)serverBox.SelectedValue;
            createLobby.Body.lobby_details.lan = createLobby.Body.lobby_details.server_region == 0;
            createLobby.Body.lobby_details.game_mode = (uint)(DotaGameModes)gmodeBox.SelectedValue;
            createLobby.Body.lobby_details.allow_cheats = cheatsButton1.Checked;
            createLobby.Body.lobby_details.cm_pick = draftRadiantButton.Checked ? DOTA_CM_PICK.DOTA_CM_GOOD_GUYS : DOTA_CM_PICK.DOTA_CM_BAD_GUYS;
            createLobby.Body.lobby_details.penalty_level_radiant = (uint)(DotaDraftPenalty)penaltyRadiantBox.SelectedValue;
            createLobby.Body.lobby_details.penalty_level_dire = (uint)(DotaDraftPenalty)penaltyDireBox.SelectedValue;
            createLobby.Body.lobby_details.visibility = DOTALobbyVisibility.DOTALobbyVisibility_Unlisted;

            _steamGameCoordinator.Send(createLobby, 570);

            var ss = new ClientGCMsgProtobuf<CMsgInviteToLobby>((uint)EGCBaseMsg.k_EMsgGCInviteToLobby)
            {
                Body = { steam_id = new SteamID(76561198065864003) }
            };
            _steamGameCoordinator.Send(ss, 570);
        }
    }
}
