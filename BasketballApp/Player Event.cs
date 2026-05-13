using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasketballApp
{
    public partial class Player_Event : Form
    {
        public Player_Event()
        {
            InitializeComponent();
        }

        private void txbAddPlayerEvent_TextChanged(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            lblAddPlayer = new Label();
            textBox1 = new TextBox();
            btnBack = new Button();
            SuspendLayout();
            // 
            // lblAddPlayer
            // 
            lblAddPlayer.AutoSize = true;
            lblAddPlayer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAddPlayer.Location = new Point(223, 191);
            lblAddPlayer.Name = "lblAddPlayer";
            lblAddPlayer.Size = new Size(84, 21);
            lblAddPlayer.TabIndex = 0;
            lblAddPlayer.Text = "AddPlayer:";
            lblAddPlayer.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(339, 189);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 23);
            textBox1.TabIndex = 1;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(1, 413);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(201, 57);
            btnBack.TabIndex = 9;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // Player_Event
            // 
            ClientSize = new Size(837, 469);
            Controls.Add(btnBack);
            Controls.Add(textBox1);
            Controls.Add(lblAddPlayer);
            Name = "Player_Event";
            Load += Player_Event_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblAddPlayer;

        private void label1_Click(object sender, EventArgs e)
        {










        }

        private TextBox textBox1;
        private Button btnBack;

        private void Player_Event_Load(object sender, EventArgs e)
        {

        }
    }
}
