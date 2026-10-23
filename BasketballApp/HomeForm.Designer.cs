namespace BasketballApp
{
    partial class Home
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
            lblwelcome = new Label();
            bntAddPlayer = new Button();
            btnQuit = new Button();
            SuspendLayout();
            // 
            // lblwelcome
            // 
            lblwelcome.AutoSize = true;
            lblwelcome.Location = new Point(347, 38);
            lblwelcome.Name = "lblwelcome";
            lblwelcome.Size = new Size(57, 15);
            lblwelcome.TabIndex = 0;
            lblwelcome.Text = "Welcome";
            // 
            // bntAddPlayer
            // 
            bntAddPlayer.Location = new Point(223, 163);
            bntAddPlayer.Name = "bntAddPlayer";
            bntAddPlayer.Size = new Size(309, 134);
            bntAddPlayer.TabIndex = 1;
            bntAddPlayer.Text = "Add Player";
            bntAddPlayer.UseVisualStyleBackColor = true;
            bntAddPlayer.Click += btnAddPlayer_Click;
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(675, 384);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(113, 54);
            btnQuit.TabIndex = 2;
            btnQuit.Text = "Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnQuit);
            Controls.Add(bntAddPlayer);
            Controls.Add(lblwelcome);
            Name = "Home";
            Text = "Home";
            Load += HomeForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblwelcome;
        private Button bntAddPlayer;
        private Button btnQuit;
    }
}