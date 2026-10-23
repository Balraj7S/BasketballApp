namespace BasketballApp
{
    partial class Match
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
            lblTeamName = new Label();
            lblAwayTeam = new Label();
            btnNext = new Button();
            btnBack = new Button();
            label3 = new Label();
            lblhomeTeam = new Label();
            dtpMatchDate = new DateTimePicker();
            cmbHomeTeam = new ComboBox();
            cmbAwayTeam = new ComboBox();
            SuspendLayout();
            // 
            // lblTeamName
            // 
            lblTeamName.AutoSize = true;
            lblTeamName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTeamName.Location = new Point(49, 138);
            lblTeamName.Name = "lblTeamName";
            lblTeamName.Size = new Size(89, 20);
            lblTeamName.TabIndex = 4;
            lblTeamName.Text = "Match Date:";
            // 
            // lblAwayTeam
            // 
            lblAwayTeam.AutoSize = true;
            lblAwayTeam.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAwayTeam.Location = new Point(49, 196);
            lblAwayTeam.Name = "lblAwayTeam";
            lblAwayTeam.Size = new Size(88, 20);
            lblAwayTeam.TabIndex = 6;
            lblAwayTeam.Text = "Away Team:";
            // 
            // btnNext
            // 
            btnNext.Location = new Point(542, 366);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(201, 57);
            btnNext.TabIndex = 11;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(48, 366);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(201, 57);
            btnBack.TabIndex = 10;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(345, 38);
            label3.Name = "label3";
            label3.Size = new Size(115, 31);
            label3.TabIndex = 12;
            label3.Text = "Basketball";
            // 
            // lblhomeTeam
            // 
            lblhomeTeam.AutoSize = true;
            lblhomeTeam.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblhomeTeam.Location = new Point(44, 167);
            lblhomeTeam.Name = "lblhomeTeam";
            lblhomeTeam.Size = new Size(93, 20);
            lblhomeTeam.TabIndex = 13;
            lblhomeTeam.Text = "Home Team:";
            // 
            // dtpMatchDate
            // 
            dtpMatchDate.Location = new Point(148, 136);
            dtpMatchDate.Name = "dtpMatchDate";
            dtpMatchDate.Size = new Size(196, 23);
            dtpMatchDate.TabIndex = 14;
            // 
            // cmbHomeTeam
            // 
            cmbHomeTeam.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbHomeTeam.FormattingEnabled = true;
            cmbHomeTeam.Location = new Point(148, 164);
            cmbHomeTeam.Name = "cmbHomeTeam";
            cmbHomeTeam.Size = new Size(196, 23);
            cmbHomeTeam.TabIndex = 15;
            // 
            // cmbAwayTeam
            // 
            cmbAwayTeam.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAwayTeam.FormattingEnabled = true;
            cmbAwayTeam.Location = new Point(148, 197);
            cmbAwayTeam.Name = "cmbAwayTeam";
            cmbAwayTeam.Size = new Size(196, 23);
            cmbAwayTeam.TabIndex = 16;
            // 
            // Match
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbAwayTeam);
            Controls.Add(cmbHomeTeam);
            Controls.Add(dtpMatchDate);
            Controls.Add(lblhomeTeam);
            Controls.Add(label3);
            Controls.Add(btnNext);
            Controls.Add(btnBack);
            Controls.Add(lblAwayTeam);
            Controls.Add(lblTeamName);
            Name = "Match";
            Text = "Match";
            Load += Match_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTeamName;
        private Label lblAwayTeam;

        private Button btnNext;
        private Button btnBack;
        private Label label3;
        private Label lblhomeTeam;
        private DateTimePicker dtpMatchDate;
        private ComboBox cmbHomeTeam;
        private ComboBox cmbAwayTeam;
    }
}