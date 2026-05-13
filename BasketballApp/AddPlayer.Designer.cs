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
            label1 = new Label();
            lblTeamName = new Label();
            txbTeamName = new TextBox();
            lblPlayerName = new Label();
            txbPlayerName = new TextBox();
            lblPlayerPosition = new Label();
            txbPlayerPosition = new TextBox();
            btnBack = new Button();
            btnNext = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(278, 30);
            label1.Name = "label1";
            label1.Size = new Size(115, 31);
            label1.TabIndex = 0;
            label1.Text = "Basketball";
            label1.Click += label1_Click;
            // 
            // lblTeamName
            // 
            lblTeamName.AutoSize = true;
            lblTeamName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTeamName.Location = new Point(55, 115);
            lblTeamName.Name = "lblTeamName";
            lblTeamName.Size = new Size(92, 20);
            lblTeamName.TabIndex = 1;
            lblTeamName.Text = "Team Name:";
            // 
            // txbTeamName
            // 
            txbTeamName.Location = new Point(154, 112);
            txbTeamName.Name = "txbTeamName";
            txbTeamName.Size = new Size(133, 23);
            txbTeamName.TabIndex = 3;
            txbTeamName.TextChanged += textBox1_TextChanged;
            // 
            // lblPlayerName
            // 
            lblPlayerName.AutoSize = true;
            lblPlayerName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPlayerName.Location = new Point(51, 151);
            lblPlayerName.Name = "lblPlayerName";
            lblPlayerName.Size = new Size(96, 20);
            lblPlayerName.TabIndex = 4;
            lblPlayerName.Text = "Player Name:";
            lblPlayerName.Click += label2_Click;
            // 
            // txbPlayerName
            // 
            txbPlayerName.Location = new Point(153, 148);
            txbPlayerName.Name = "txbPlayerName";
            txbPlayerName.Size = new Size(134, 23);
            txbPlayerName.TabIndex = 5;
            // 
            // lblPlayerPosition
            // 
            lblPlayerPosition.AutoSize = true;
            lblPlayerPosition.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPlayerPosition.Location = new Point(39, 182);
            lblPlayerPosition.Name = "lblPlayerPosition";
            lblPlayerPosition.Size = new Size(108, 20);
            lblPlayerPosition.TabIndex = 6;
            lblPlayerPosition.Text = "Player Position:";
            // 
            // txbPlayerPosition
            // 
            txbPlayerPosition.Location = new Point(153, 179);
            txbPlayerPosition.Name = "txbPlayerPosition";
            txbPlayerPosition.Size = new Size(134, 23);
            txbPlayerPosition.TabIndex = 7;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(14, 365);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(201, 57);
            btnBack.TabIndex = 8;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(508, 365);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(201, 57);
            btnNext.TabIndex = 9;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            // 
            // AddPlayer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(721, 449);
            Controls.Add(btnNext);
            Controls.Add(btnBack);
            Controls.Add(txbPlayerPosition);
            Controls.Add(lblPlayerPosition);
            Controls.Add(txbPlayerName);
            Controls.Add(lblPlayerName);
            Controls.Add(txbTeamName);
            Controls.Add(lblTeamName);
            Controls.Add(label1);
            Name = "AddPlayer";
            Text = "Team Form";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblTeamName;
        private TextBox txbTeamName;
        private Label lblPlayerName;
        private TextBox txbPlayerName;
        private Label lblPlayerPosition;
        private TextBox txbPlayerPosition;
        private Button btnBack;
        private Button btnNext;
    }
}
