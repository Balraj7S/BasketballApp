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
    public partial class MatchEvent : Form
    {

        OleDbConnection connection = new OleDbConnection();
        int playerId;
        int matchId;
        int teamId;
        public MatchEvent(int pId, int mId, int tId)
        {
            InitializeComponent();
            playerId = pId;
            matchId = mId;
            teamId = tId;
            connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\\\filesrvr01\\home\\balrsing\\My Documents\\Projects\\BasketballApp\\BasketballApp\\dbBasketball.accdb;";
            connection.Open();
            connection.Close();
        }

        private void txbAddPlayerEvent_TextChanged(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            lblAddPlayer = new Label();
            tbxMatchEvent = new TextBox();
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
            // tbxMatchEvent
            // 
            tbxMatchEvent.Location = new Point(339, 189);
            tbxMatchEvent.Name = "tbxMatchEvent";
            tbxMatchEvent.Size = new Size(200, 23);
            tbxMatchEvent.TabIndex = 1;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(0, 413);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(168, 57);
            btnBack.TabIndex = 9;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
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
            // MatchEvent
            // 
            ClientSize = new Size(837, 469);
            Controls.Add(bntNext);
            Controls.Add(btnBack);
            Controls.Add(tbxMatchEvent);
            Controls.Add(lblAddPlayer);
            Name = "MatchEvent";
            Load += Player_Event_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblAddPlayer;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private TextBox tbxMatchEvent;
        private Button btnBack;

        private void Player_Event_Load(object sender, EventArgs e)
        {

        }

        private Button bntNext;

        private void bntNext_Click(object sender, EventArgs e)
        {

            try
            {
                if (tbxMatchEvent.Text == "")
                {
                    MessageBox.Show("Please enter an event!");
                    return;
                }


                if (connection.State == ConnectionState.Open) connection.Close();
                connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\\\filesrvr01\\home\\balrsing\\My Documents\\Projects\\BasketballApp\\BasketballApp\\dbBasketball.accdb;";
                OleDbCommand command = new OleDbCommand();
                connection.Open();
                command.Connection = connection;
                MessageBox.Show("Player ID: " + " playerId " + "Match ID: " + matchId);
                command.CommandText = "INSERT INTO tblMatchEvent (PlayerId,MatchId,Event) VALUES (" + playerId + "," + matchId + ",'" + tbxMatchEvent.Text + "')";
                command.ExecuteNonQuery();
                MessageBox.Show("Event Saved!");
                connection.Close();
                Finish finishForm = new Finish();
                finishForm.Show();
                this.Hide();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);

            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Match matchForm = new Match(playerId, teamId);
            matchForm.Show();
            this.Hide();
        }
    }
}