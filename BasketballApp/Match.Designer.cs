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
            txbMatchDate = new TextBox();
            lblTeamName = new Label();
            txbAwayTeam = new TextBox();
            label1 = new Label();
            txbHomeTeam = new TextBox();
            btnNext = new Button();
            btnBack = new Button();
            label3 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txbMatchDate
            // 
            txbMatchDate.Location = new Point(148, 135);
            txbMatchDate.Name = "txbMatchDate";
            txbMatchDate.Size = new Size(133, 23);
            txbMatchDate.TabIndex = 5;
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
            // txbAwayTeam
            // 
            txbAwayTeam.Location = new Point(148, 193);
            txbAwayTeam.Name = "txbAwayTeam";
            txbAwayTeam.Size = new Size(133, 23);
            txbAwayTeam.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(49, 196);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 6;
            label1.Text = "Away Team:";
            // 
            // txbHomeTeam
            // 
            txbHomeTeam.Location = new Point(148, 164);
            txbHomeTeam.Name = "txbHomeTeam";
            txbHomeTeam.Size = new Size(133, 23);
            txbHomeTeam.TabIndex = 9;
            txbHomeTeam.TextChanged += textBox2_TextChanged;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(542, 366);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(201, 57);
            btnNext.TabIndex = 11;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(48, 366);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(201, 57);
            btnBack.TabIndex = 10;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(44, 167);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 13;
            label2.Text = "Home Team:";
            // 
            // Match
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(btnNext);
            Controls.Add(btnBack);
            Controls.Add(txbHomeTeam);
            Controls.Add(txbAwayTeam);
            Controls.Add(label1);
            Controls.Add(txbMatchDate);
            Controls.Add(lblTeamName);
            Name = "Match";
            Text = "Match";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txbMatchDate;
        private Label lblTeamName;
        private TextBox txbAwayTeam;
        private Label label1;
        private TextBox txbHomeTeam;

        private Button btnNext;
        private Button btnBack;
        private Label label3;
        private Label label2;
    }
}