namespace BasketballApp
{
    partial class AddPlayer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTeamName = new Label();
            lblPlayerName = new Label();
            txbPlayerName = new TextBox();
            lblPlayerPosition = new Label();
            txbPlayerPosition = new TextBox();
            btnBack = new Button();
            btnNext = new Button();
            lblPlayerSurname = new Label();
            txbPlayerSurname = new TextBox();
            dGVPlayerView = new DataGridView();
            btnViewPlayer = new Button();
            cmbTeamName = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dGVPlayerView).BeginInit();
            SuspendLayout();
            // 
            // lblTeamName
            // 
            lblTeamName.AutoSize = true;
            lblTeamName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTeamName.Location = new Point(28, 115);
            lblTeamName.Name = "lblTeamName";
            lblTeamName.Size = new Size(92, 20);
            lblTeamName.TabIndex = 1;
            lblTeamName.Text = "Team Name:";
            // 
            // lblPlayerName
            // 
            lblPlayerName.AutoSize = true;
            lblPlayerName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPlayerName.Location = new Point(24, 151);
            lblPlayerName.Name = "lblPlayerName";
            lblPlayerName.Size = new Size(96, 20);
            lblPlayerName.TabIndex = 4;
            lblPlayerName.Text = "Player Name:";
            // 
            // txbPlayerName
            // 
            txbPlayerName.Location = new Point(126, 148);
            txbPlayerName.Name = "txbPlayerName";
            txbPlayerName.Size = new Size(134, 23);
            txbPlayerName.TabIndex = 5;
            // 
            // lblPlayerPosition
            // 
            lblPlayerPosition.AutoSize = true;
            lblPlayerPosition.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPlayerPosition.Location = new Point(6, 215);
            lblPlayerPosition.Name = "lblPlayerPosition";
            lblPlayerPosition.Size = new Size(108, 20);
            lblPlayerPosition.TabIndex = 6;
            lblPlayerPosition.Text = "Player Position:";
            lblPlayerPosition.Click += lblPlayerPosition_Click;
            // 
            // txbPlayerPosition
            // 
            txbPlayerPosition.Location = new Point(127, 212);
            txbPlayerPosition.Name = "txbPlayerPosition";
            txbPlayerPosition.Size = new Size(134, 23);
            txbPlayerPosition.TabIndex = 7;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(1, 365);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(201, 57);
            btnBack.TabIndex = 8;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(525, 361);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(201, 57);
            btnNext.TabIndex = 9;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // lblPlayerSurname
            // 
            lblPlayerSurname.AutoSize = true;
            lblPlayerSurname.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPlayerSurname.Location = new Point(6, 183);
            lblPlayerSurname.Name = "lblPlayerSurname";
            lblPlayerSurname.Size = new Size(114, 20);
            lblPlayerSurname.TabIndex = 10;
            lblPlayerSurname.Text = "Player Surname:";
            lblPlayerSurname.Click += label1_Click;
            // 
            // txbPlayerSurname
            // 
            txbPlayerSurname.Location = new Point(126, 180);
            txbPlayerSurname.Name = "txbPlayerSurname";
            txbPlayerSurname.Size = new Size(134, 23);
            txbPlayerSurname.TabIndex = 11;
            // 
            // dGVPlayerView
            // 
            dGVPlayerView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGVPlayerView.Location = new Point(272, 87);
            dGVPlayerView.Name = "dGVPlayerView";
            dGVPlayerView.ReadOnly = true;
            dGVPlayerView.Size = new Size(474, 243);
            dGVPlayerView.TabIndex = 13;
            // 
            // btnViewPlayer
            // 
            btnViewPlayer.Location = new Point(272, 363);
            btnViewPlayer.Name = "btnViewPlayer";
            btnViewPlayer.Size = new Size(182, 52);
            btnViewPlayer.TabIndex = 14;
            btnViewPlayer.Text = "View Player";
            btnViewPlayer.UseVisualStyleBackColor = true;
            btnViewPlayer.Click += btnViewPlayer_Click;
            // 
            // cmbTeamName
            // 
            cmbTeamName.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTeamName.FormattingEnabled = true;
            cmbTeamName.Location = new Point(126, 115);
            cmbTeamName.Name = "cmbTeamName";
            cmbTeamName.Size = new Size(134, 23);
            cmbTeamName.TabIndex = 12;
            // 
            // AddPlayer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(758, 449);
            Controls.Add(btnViewPlayer);
            Controls.Add(dGVPlayerView);
            Controls.Add(cmbTeamName);
            Controls.Add(txbPlayerSurname);
            Controls.Add(lblPlayerSurname);
            Controls.Add(btnNext);
            Controls.Add(btnBack);
            Controls.Add(txbPlayerPosition);
            Controls.Add(lblPlayerPosition);
            Controls.Add(txbPlayerName);
            Controls.Add(lblPlayerName);
            Controls.Add(lblTeamName);
            Name = "AddPlayer";
            Text = " ";
            Load += AddPlayer_Load;
            ((System.ComponentModel.ISupportInitialize)dGVPlayerView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTeamName;
        private Label lblPlayerName;
        private TextBox txbPlayerName;
        private Label lblPlayerPosition;
        private TextBox txbPlayerPosition;
        private Button btnBack;
        private Button btnNext;
        private Label lblPlayerSurname;
        private TextBox txbPlayerSurname;
        private DataGridView dGVPlayerView;
        private Button btnViewPlayer;
        private ComboBox cmbTeamName;
    }
}
