using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasketballApp
{
    public partial class PlayerEvent : Form
    {
        OleDbConnection connection = new OleDbConnection();
        int playerId;
        int matchId;
        public PlayerEvent()
        {
            InitializeComponent();
        }

        private void txbAddPlayerEvent_TextChanged(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            lblAddPlayer = new Label();
            tbxPlayerEvent = new TextBox();
            btnBack = new Button();
            bntNext = new Button();
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
            // tbxPlayerEvent
            // 
            tbxPlayerEvent.Location = new Point(339, 189);
            tbxPlayerEvent.Name = "tbxPlayerEvent";
            tbxPlayerEvent.Size = new Size(200, 23);
            tbxPlayerEvent.TabIndex = 1;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(0, 413);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(168, 57);
            btnBack.TabIndex = 9;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // bntNext
            // 
            bntNext.Location = new Point(657, 413);
            bntNext.Name = "bntNext";
            bntNext.Size = new Size(179, 57);
            bntNext.TabIndex = 10;
            bntNext.Text = "Next";
            bntNext.UseVisualStyleBackColor = true;
            bntNext.Click += bntNext_Click;
            // 
            // PlayerEvent
            // 
            ClientSize = new Size(837, 469);
            Controls.Add(bntNext);
            Controls.Add(btnBack);
            Controls.Add(tbxPlayerEvent);
            Controls.Add(lblAddPlayer);
            Name = "PlayerEvent";
            Load += Player_Event_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblAddPlayer;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private TextBox tbxPlayerEvent;
        private Button btnBack;

        private void Player_Event_Load(object sender, EventArgs e)
        {

        }

        private Button bntNext;

        private void bntNext_Click(object sender, EventArgs e)
        {                                                                                             
           
            try
            {
                if (connection.State == ConnectionState.Open) connection.Close();
                connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\dbBasketball.accdb";
                OleDbCommand command = new OleDbCommand();
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO tblMatchEvent (PlayerId,MatchId,Event) VALUES (" + playerId + "," + matchId + ",'" + tbxPlayerEvent.Text + "')";
                command.ExecuteNonQuery();
                command.CommandText = "SELECT @@IDENTITY";
                int playerId = Convert.ToInt32(command.ExecuteScalar());
                MessageBox.Show("Event Saved");
                connection.Close();
                Finish finishForm = new Finish();
                this.Hide();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);

            }
        }
    }
}
