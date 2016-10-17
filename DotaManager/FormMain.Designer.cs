using System.ComponentModel;
using System.Windows.Forms;

namespace DotaManager
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginGroup = new System.Windows.Forms.GroupBox();
            this.logoutButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.playButton = new System.Windows.Forms.Button();
            this.playGroup = new System.Windows.Forms.GroupBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.dotaStatusLabel = new System.Windows.Forms.Label();
            this.SteamStatusLabel = new System.Windows.Forms.Label();
            this.mainTable = new System.Windows.Forms.TableLayoutPanel();
            this.partyGroup = new System.Windows.Forms.GroupBox();
            this.testBox = new System.Windows.Forms.TextBox();
            this.lobbyBox = new System.Windows.Forms.GroupBox();
            this.loginGroup.SuspendLayout();
            this.playGroup.SuspendLayout();
            this.mainTable.SuspendLayout();
            this.partyGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginGroup
            // 
            this.loginGroup.Controls.Add(this.logoutButton);
            this.loginGroup.Controls.Add(this.loginButton);
            this.loginGroup.Controls.Add(this.passwordBox);
            this.loginGroup.Controls.Add(this.usernameBox);
            this.loginGroup.Location = new System.Drawing.Point(12, 12);
            this.loginGroup.Name = "loginGroup";
            this.loginGroup.Size = new System.Drawing.Size(335, 71);
            this.loginGroup.TabIndex = 1;
            this.loginGroup.TabStop = false;
            this.loginGroup.Text = "Credentials";
            // 
            // logoutButton
            // 
            this.logoutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.Location = new System.Drawing.Point(227, 45);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(102, 20);
            this.logoutButton.TabIndex = 4;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.Location = new System.Drawing.Point(227, 19);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(102, 20);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // passwordBox
            // 
            this.passwordBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordBox.Location = new System.Drawing.Point(6, 45);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(215, 20);
            this.passwordBox.TabIndex = 2;
            // 
            // usernameBox
            // 
            this.usernameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usernameBox.Location = new System.Drawing.Point(6, 19);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(215, 20);
            this.usernameBox.TabIndex = 1;
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(6, 32);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(100, 33);
            this.playButton.TabIndex = 1;
            this.playButton.Text = "Launch DOTA";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // playGroup
            // 
            this.playGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.playGroup.Controls.Add(this.connectButton);
            this.playGroup.Controls.Add(this.dotaStatusLabel);
            this.playGroup.Controls.Add(this.SteamStatusLabel);
            this.playGroup.Controls.Add(this.playButton);
            this.playGroup.Location = new System.Drawing.Point(353, 12);
            this.playGroup.Name = "playGroup";
            this.playGroup.Size = new System.Drawing.Size(219, 71);
            this.playGroup.TabIndex = 2;
            this.playGroup.TabStop = false;
            this.playGroup.Text = "Dota";
            // 
            // connectButton
            // 
            this.connectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.connectButton.Location = new System.Drawing.Point(113, 32);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(100, 33);
            this.connectButton.TabIndex = 2;
            this.connectButton.Text = "Connect All";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // dotaStatusLabel
            // 
            this.dotaStatusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dotaStatusLabel.Location = new System.Drawing.Point(113, 16);
            this.dotaStatusLabel.Name = "dotaStatusLabel";
            this.dotaStatusLabel.Size = new System.Drawing.Size(100, 13);
            this.dotaStatusLabel.TabIndex = 0;
            this.dotaStatusLabel.Text = "Dota: Stopped";
            this.dotaStatusLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // SteamStatusLabel
            // 
            this.SteamStatusLabel.Location = new System.Drawing.Point(6, 16);
            this.SteamStatusLabel.Name = "SteamStatusLabel";
            this.SteamStatusLabel.Size = new System.Drawing.Size(100, 13);
            this.SteamStatusLabel.TabIndex = 0;
            this.SteamStatusLabel.Text = "Steam: Stopped";
            // 
            // mainTable
            // 
            this.mainTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTable.ColumnCount = 4;
            this.mainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mainTable.Controls.Add(this.partyGroup, 0, 0);
            this.mainTable.Controls.Add(this.lobbyBox, 1, 0);
            this.mainTable.Location = new System.Drawing.Point(12, 89);
            this.mainTable.Name = "mainTable";
            this.mainTable.RowCount = 1;
            this.mainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTable.Size = new System.Drawing.Size(560, 260);
            this.mainTable.TabIndex = 3;
            // 
            // partyGroup
            // 
            this.partyGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.partyGroup.Controls.Add(this.testBox);
            this.partyGroup.Location = new System.Drawing.Point(3, 3);
            this.partyGroup.Name = "partyGroup";
            this.partyGroup.Size = new System.Drawing.Size(134, 254);
            this.partyGroup.TabIndex = 1;
            this.partyGroup.TabStop = false;
            this.partyGroup.Text = "Party";
            // 
            // testBox
            // 
            this.testBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.testBox.Location = new System.Drawing.Point(6, 19);
            this.testBox.Multiline = true;
            this.testBox.Name = "testBox";
            this.testBox.Size = new System.Drawing.Size(122, 229);
            this.testBox.TabIndex = 1;
            // 
            // lobbyBox
            // 
            this.lobbyBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lobbyBox.Location = new System.Drawing.Point(143, 3);
            this.lobbyBox.Name = "lobbyBox";
            this.lobbyBox.Size = new System.Drawing.Size(134, 254);
            this.lobbyBox.TabIndex = 2;
            this.lobbyBox.TabStop = false;
            this.lobbyBox.Text = "Lobby";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.mainTable);
            this.Controls.Add(this.playGroup);
            this.Controls.Add(this.loginGroup);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "FormMain";
            this.Text = "Dota2 Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_Closing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.loginGroup.ResumeLayout(false);
            this.loginGroup.PerformLayout();
            this.playGroup.ResumeLayout(false);
            this.mainTable.ResumeLayout(false);
            this.partyGroup.ResumeLayout(false);
            this.partyGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox loginGroup;
        private TextBox usernameBox;
        private Button loginButton;
        private TextBox passwordBox;
        private Button logoutButton;
        private Button playButton;
        private GroupBox playGroup;
        private Label dotaStatusLabel;
        private Label SteamStatusLabel;
        private Button connectButton;
        private TableLayoutPanel mainTable;
        private GroupBox partyGroup;
        private TextBox testBox;
        private GroupBox lobbyBox;
    }
}