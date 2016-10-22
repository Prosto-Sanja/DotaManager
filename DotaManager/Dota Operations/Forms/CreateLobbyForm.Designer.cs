namespace DotaManager.Dota_Operations.Forms
{
    partial class CreateLobbyForm
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
            this.nameBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.passLabel = new System.Windows.Forms.Label();
            this.passBox = new System.Windows.Forms.TextBox();
            this.serverLabel = new System.Windows.Forms.Label();
            this.serverBox = new System.Windows.Forms.ComboBox();
            this.modeLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cheatsLabel = new System.Windows.Forms.Label();
            this.cheatsButton1 = new System.Windows.Forms.RadioButton();
            this.cheatsButton2 = new System.Windows.Forms.RadioButton();
            this.mainBox = new System.Windows.Forms.GroupBox();
            this.systemBox = new System.Windows.Forms.GroupBox();
            this.draftLabel = new System.Windows.Forms.Label();
            this.draftBox = new System.Windows.Forms.ComboBox();
            this.penaltyLabel = new System.Windows.Forms.Label();
            this.penaltyRadiantBox = new System.Windows.Forms.ComboBox();
            this.penaltyDireBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gameBox = new System.Windows.Forms.GroupBox();
            this.spectatorsLabel = new System.Windows.Forms.Label();
            this.spectatorsButton1 = new System.Windows.Forms.RadioButton();
            this.spectatorsButton2 = new System.Windows.Forms.RadioButton();
            this.dotatvLabel = new System.Windows.Forms.Label();
            this.dotatvBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.seriesLabel = new System.Windows.Forms.Label();
            this.seriesBox = new System.Windows.Forms.ComboBox();
            this.winRadiantBox = new System.Windows.Forms.ComboBox();
            this.winDireBox = new System.Windows.Forms.ComboBox();
            this.prevmatchLabel = new System.Windows.Forms.Label();
            this.prevmatchBox = new System.Windows.Forms.TextBox();
            this.mainBox.SuspendLayout();
            this.systemBox.SuspendLayout();
            this.gameBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(60, 19);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(294, 20);
            this.nameBox.TabIndex = 1;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(6, 22);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name:";
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Location = new System.Drawing.Point(6, 48);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(33, 13);
            this.passLabel.TabIndex = 0;
            this.passLabel.Text = "Pass:";
            // 
            // passBox
            // 
            this.passBox.Location = new System.Drawing.Point(60, 45);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(294, 20);
            this.passBox.TabIndex = 2;
            this.passBox.UseSystemPasswordChar = true;
            // 
            // serverLabel
            // 
            this.serverLabel.AutoSize = true;
            this.serverLabel.Location = new System.Drawing.Point(6, 74);
            this.serverLabel.Name = "serverLabel";
            this.serverLabel.Size = new System.Drawing.Size(41, 13);
            this.serverLabel.TabIndex = 0;
            this.serverLabel.Text = "Server:";
            // 
            // serverBox
            // 
            this.serverBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.serverBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.serverBox.FormattingEnabled = true;
            this.serverBox.Items.AddRange(new object[] {
            "SS1",
            "SS2",
            "DD3",
            "FG5",
            "RET1"});
            this.serverBox.Location = new System.Drawing.Point(60, 71);
            this.serverBox.Name = "serverBox";
            this.serverBox.Size = new System.Drawing.Size(294, 21);
            this.serverBox.TabIndex = 3;
            // 
            // modeLabel
            // 
            this.modeLabel.AutoSize = true;
            this.modeLabel.Location = new System.Drawing.Point(6, 101);
            this.modeLabel.Name = "modeLabel";
            this.modeLabel.Size = new System.Drawing.Size(48, 13);
            this.modeLabel.TabIndex = 0;
            this.modeLabel.Text = "G Mode:";
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(60, 98);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // cheatsLabel
            // 
            this.cheatsLabel.AutoSize = true;
            this.cheatsLabel.Location = new System.Drawing.Point(217, 101);
            this.cheatsLabel.Name = "cheatsLabel";
            this.cheatsLabel.Size = new System.Drawing.Size(43, 13);
            this.cheatsLabel.TabIndex = 0;
            this.cheatsLabel.Text = "Cheats:";
            // 
            // cheatsButton1
            // 
            this.cheatsButton1.AutoSize = true;
            this.cheatsButton1.Location = new System.Drawing.Point(266, 99);
            this.cheatsButton1.Name = "cheatsButton1";
            this.cheatsButton1.Size = new System.Drawing.Size(43, 17);
            this.cheatsButton1.TabIndex = 5;
            this.cheatsButton1.TabStop = true;
            this.cheatsButton1.Text = "Yes";
            this.cheatsButton1.UseVisualStyleBackColor = true;
            // 
            // cheatsButton2
            // 
            this.cheatsButton2.AutoSize = true;
            this.cheatsButton2.Location = new System.Drawing.Point(315, 99);
            this.cheatsButton2.Name = "cheatsButton2";
            this.cheatsButton2.Size = new System.Drawing.Size(39, 17);
            this.cheatsButton2.TabIndex = 6;
            this.cheatsButton2.TabStop = true;
            this.cheatsButton2.Text = "No";
            this.cheatsButton2.UseVisualStyleBackColor = true;
            // 
            // mainBox
            // 
            this.mainBox.Controls.Add(this.nameLabel);
            this.mainBox.Controls.Add(this.cheatsButton2);
            this.mainBox.Controls.Add(this.nameBox);
            this.mainBox.Controls.Add(this.passLabel);
            this.mainBox.Controls.Add(this.cheatsButton1);
            this.mainBox.Controls.Add(this.passBox);
            this.mainBox.Controls.Add(this.cheatsLabel);
            this.mainBox.Controls.Add(this.serverLabel);
            this.mainBox.Controls.Add(this.comboBox1);
            this.mainBox.Controls.Add(this.serverBox);
            this.mainBox.Controls.Add(this.modeLabel);
            this.mainBox.Location = new System.Drawing.Point(12, 12);
            this.mainBox.Name = "mainBox";
            this.mainBox.Size = new System.Drawing.Size(360, 125);
            this.mainBox.TabIndex = 1;
            this.mainBox.TabStop = false;
            this.mainBox.Text = "Main Settings";
            // 
            // systemBox
            // 
            this.systemBox.Controls.Add(this.label1);
            this.systemBox.Controls.Add(this.penaltyDireBox);
            this.systemBox.Controls.Add(this.penaltyRadiantBox);
            this.systemBox.Controls.Add(this.penaltyLabel);
            this.systemBox.Controls.Add(this.draftBox);
            this.systemBox.Controls.Add(this.draftLabel);
            this.systemBox.Location = new System.Drawing.Point(12, 143);
            this.systemBox.Name = "systemBox";
            this.systemBox.Size = new System.Drawing.Size(360, 119);
            this.systemBox.TabIndex = 2;
            this.systemBox.TabStop = false;
            this.systemBox.Text = "System Settings";
            // 
            // draftLabel
            // 
            this.draftLabel.AutoSize = true;
            this.draftLabel.Location = new System.Drawing.Point(6, 22);
            this.draftLabel.Name = "draftLabel";
            this.draftLabel.Size = new System.Drawing.Size(58, 13);
            this.draftLabel.TabIndex = 0;
            this.draftLabel.Text = "Draft Start:";
            // 
            // draftBox
            // 
            this.draftBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.draftBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.draftBox.FormattingEnabled = true;
            this.draftBox.Location = new System.Drawing.Point(70, 19);
            this.draftBox.Name = "draftBox";
            this.draftBox.Size = new System.Drawing.Size(284, 21);
            this.draftBox.TabIndex = 1;
            // 
            // penaltyLabel
            // 
            this.penaltyLabel.AutoSize = true;
            this.penaltyLabel.Location = new System.Drawing.Point(6, 49);
            this.penaltyLabel.Name = "penaltyLabel";
            this.penaltyLabel.Size = new System.Drawing.Size(45, 13);
            this.penaltyLabel.TabIndex = 0;
            this.penaltyLabel.Text = "Penalty:";
            // 
            // penaltyRadiantBox
            // 
            this.penaltyRadiantBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.penaltyRadiantBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.penaltyRadiantBox.FormattingEnabled = true;
            this.penaltyRadiantBox.Items.AddRange(new object[] {
            "Radiant - None",
            "30 sec ban",
            "70 sec ban",
            "110 sec ban"});
            this.penaltyRadiantBox.Location = new System.Drawing.Point(70, 46);
            this.penaltyRadiantBox.Name = "penaltyRadiantBox";
            this.penaltyRadiantBox.Size = new System.Drawing.Size(139, 21);
            this.penaltyRadiantBox.TabIndex = 2;
            this.penaltyRadiantBox.Text = "Radiant";
            // 
            // penaltyDireBox
            // 
            this.penaltyDireBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.penaltyDireBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.penaltyDireBox.FormattingEnabled = true;
            this.penaltyDireBox.Items.AddRange(new object[] {
            "Dire - None",
            "30 sec ban",
            "70 sec ban",
            "110 sec ban"});
            this.penaltyDireBox.Location = new System.Drawing.Point(215, 46);
            this.penaltyDireBox.Name = "penaltyDireBox";
            this.penaltyDireBox.Size = new System.Drawing.Size(139, 21);
            this.penaltyDireBox.TabIndex = 3;
            this.penaltyDireBox.Text = "Dire";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TO ADD LEAGUE OPTIONS";
            // 
            // gameBox
            // 
            this.gameBox.Controls.Add(this.prevmatchBox);
            this.gameBox.Controls.Add(this.prevmatchLabel);
            this.gameBox.Controls.Add(this.winDireBox);
            this.gameBox.Controls.Add(this.winRadiantBox);
            this.gameBox.Controls.Add(this.seriesBox);
            this.gameBox.Controls.Add(this.seriesLabel);
            this.gameBox.Controls.Add(this.comboBox2);
            this.gameBox.Controls.Add(this.label2);
            this.gameBox.Controls.Add(this.dotatvBox);
            this.gameBox.Controls.Add(this.dotatvLabel);
            this.gameBox.Controls.Add(this.spectatorsButton2);
            this.gameBox.Controls.Add(this.spectatorsButton1);
            this.gameBox.Controls.Add(this.spectatorsLabel);
            this.gameBox.Location = new System.Drawing.Point(12, 268);
            this.gameBox.Name = "gameBox";
            this.gameBox.Size = new System.Drawing.Size(360, 125);
            this.gameBox.TabIndex = 3;
            this.gameBox.TabStop = false;
            this.gameBox.Text = "Game Settings";
            // 
            // spectatorsLabel
            // 
            this.spectatorsLabel.AutoSize = true;
            this.spectatorsLabel.Location = new System.Drawing.Point(6, 21);
            this.spectatorsLabel.Name = "spectatorsLabel";
            this.spectatorsLabel.Size = new System.Drawing.Size(40, 13);
            this.spectatorsLabel.TabIndex = 0;
            this.spectatorsLabel.Text = "Specs:";
            // 
            // spectatorsButton1
            // 
            this.spectatorsButton1.AutoSize = true;
            this.spectatorsButton1.Location = new System.Drawing.Point(52, 19);
            this.spectatorsButton1.Name = "spectatorsButton1";
            this.spectatorsButton1.Size = new System.Drawing.Size(64, 17);
            this.spectatorsButton1.TabIndex = 1;
            this.spectatorsButton1.TabStop = true;
            this.spectatorsButton1.Text = "Enabled";
            this.spectatorsButton1.UseVisualStyleBackColor = true;
            // 
            // spectatorsButton2
            // 
            this.spectatorsButton2.AutoSize = true;
            this.spectatorsButton2.Location = new System.Drawing.Point(122, 19);
            this.spectatorsButton2.Name = "spectatorsButton2";
            this.spectatorsButton2.Size = new System.Drawing.Size(66, 17);
            this.spectatorsButton2.TabIndex = 2;
            this.spectatorsButton2.TabStop = true;
            this.spectatorsButton2.Text = "Disabled";
            this.spectatorsButton2.UseVisualStyleBackColor = true;
            // 
            // dotatvLabel
            // 
            this.dotatvLabel.AutoSize = true;
            this.dotatvLabel.Location = new System.Drawing.Point(194, 21);
            this.dotatvLabel.Name = "dotatvLabel";
            this.dotatvLabel.Size = new System.Drawing.Size(62, 13);
            this.dotatvLabel.TabIndex = 0;
            this.dotatvLabel.Text = "DTV Delay:";
            // 
            // dotatvBox
            // 
            this.dotatvBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.dotatvBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.dotatvBox.FormattingEnabled = true;
            this.dotatvBox.Items.AddRange(new object[] {
            "10 sec",
            "2 min",
            "5 min"});
            this.dotatvBox.Location = new System.Drawing.Point(262, 18);
            this.dotatvBox.Name = "dotatvBox";
            this.dotatvBox.Size = new System.Drawing.Size(92, 21);
            this.dotatvBox.TabIndex = 3;
            this.dotatvBox.Text = "5 min";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Pause Settings:";
            // 
            // comboBox2
            // 
            this.comboBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Limited",
            "Unlimited",
            "Disabled"});
            this.comboBox2.Location = new System.Drawing.Point(93, 45);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(261, 21);
            this.comboBox2.TabIndex = 4;
            this.comboBox2.Text = "Limited";
            // 
            // seriesLabel
            // 
            this.seriesLabel.AutoSize = true;
            this.seriesLabel.Location = new System.Drawing.Point(6, 75);
            this.seriesLabel.Name = "seriesLabel";
            this.seriesLabel.Size = new System.Drawing.Size(66, 13);
            this.seriesLabel.TabIndex = 0;
            this.seriesLabel.Text = "Series Type:";
            // 
            // seriesBox
            // 
            this.seriesBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.seriesBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.seriesBox.FormattingEnabled = true;
            this.seriesBox.Items.AddRange(new object[] {
            "None",
            "BO3",
            "BO5"});
            this.seriesBox.Location = new System.Drawing.Point(93, 72);
            this.seriesBox.Name = "seriesBox";
            this.seriesBox.Size = new System.Drawing.Size(95, 21);
            this.seriesBox.TabIndex = 5;
            this.seriesBox.Text = "None";
            // 
            // winRadiantBox
            // 
            this.winRadiantBox.FormattingEnabled = true;
            this.winRadiantBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.winRadiantBox.Location = new System.Drawing.Point(194, 72);
            this.winRadiantBox.Name = "winRadiantBox";
            this.winRadiantBox.Size = new System.Drawing.Size(77, 21);
            this.winRadiantBox.TabIndex = 6;
            this.winRadiantBox.Text = "Radiant";
            // 
            // winDireBox
            // 
            this.winDireBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.winDireBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.winDireBox.FormattingEnabled = true;
            this.winDireBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.winDireBox.Location = new System.Drawing.Point(277, 72);
            this.winDireBox.Name = "winDireBox";
            this.winDireBox.Size = new System.Drawing.Size(77, 21);
            this.winDireBox.TabIndex = 7;
            this.winDireBox.Text = "Dire";
            // 
            // prevmatchLabel
            // 
            this.prevmatchLabel.AutoSize = true;
            this.prevmatchLabel.Location = new System.Drawing.Point(6, 102);
            this.prevmatchLabel.Name = "prevmatchLabel";
            this.prevmatchLabel.Size = new System.Drawing.Size(65, 13);
            this.prevmatchLabel.TabIndex = 0;
            this.prevmatchLabel.Text = "Prev Match:";
            // 
            // prevmatchBox
            // 
            this.prevmatchBox.Location = new System.Drawing.Point(93, 99);
            this.prevmatchBox.Name = "prevmatchBox";
            this.prevmatchBox.Size = new System.Drawing.Size(261, 20);
            this.prevmatchBox.TabIndex = 8;
            // 
            // CreateLobbyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 400);
            this.Controls.Add(this.gameBox);
            this.Controls.Add(this.systemBox);
            this.Controls.Add(this.mainBox);
            this.Name = "CreateLobbyForm";
            this.Text = "Create Lobby Settings";
            this.mainBox.ResumeLayout(false);
            this.mainBox.PerformLayout();
            this.systemBox.ResumeLayout(false);
            this.systemBox.PerformLayout();
            this.gameBox.ResumeLayout(false);
            this.gameBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.Label serverLabel;
        private System.Windows.Forms.ComboBox serverBox;
        private System.Windows.Forms.Label modeLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label cheatsLabel;
        private System.Windows.Forms.RadioButton cheatsButton1;
        private System.Windows.Forms.RadioButton cheatsButton2;
        private System.Windows.Forms.GroupBox mainBox;
        private System.Windows.Forms.GroupBox systemBox;
        private System.Windows.Forms.ComboBox penaltyDireBox;
        private System.Windows.Forms.ComboBox penaltyRadiantBox;
        private System.Windows.Forms.Label penaltyLabel;
        private System.Windows.Forms.ComboBox draftBox;
        private System.Windows.Forms.Label draftLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gameBox;
        private System.Windows.Forms.RadioButton spectatorsButton2;
        private System.Windows.Forms.RadioButton spectatorsButton1;
        private System.Windows.Forms.Label spectatorsLabel;
        private System.Windows.Forms.ComboBox dotatvBox;
        private System.Windows.Forms.Label dotatvLabel;
        private System.Windows.Forms.TextBox prevmatchBox;
        private System.Windows.Forms.Label prevmatchLabel;
        private System.Windows.Forms.ComboBox winDireBox;
        private System.Windows.Forms.ComboBox winRadiantBox;
        private System.Windows.Forms.ComboBox seriesBox;
        private System.Windows.Forms.Label seriesLabel;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
    }
}