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
    public partial class Match : Form
    {
        OleDbConnection connection = new OleDbConnection();
        int selectedTeamId;
        int PlayerId;

        public Match(int PlayerId,int teamId)
        {
            InitializeComponent();
            selectedTeamId = teamId;
            connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\dbBasketball.accdb";
            connection.Open();
            OleDbCommand command = new OleDbCommand("SELECT TeamId,TeamName FROM tblTeams", connection);
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                cmbHomeTeam.Items.Add(reader["TeamName"].ToString());
                cmbAwayteam.Items.Add(reader["TeamName"].ToString());
            }
            connection.Close();
            cmbHomeTeam.SelectedIndex = selectedTeamId - 1;
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Match_Load(object sender, EventArgs e)
        {

        }

        private void txbAwayTeam_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {

            try
            {
                if (connection.State == ConnectionState.Open) connection.Close();
                connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\dbBasketball.accdb";
                OleDbCommand command = new OleDbCommand();
                connection.Open();
                command.Connection = connection;
                int homeTeamId = cmbHomeTeam.SelectedIndex + 1;
                int awayTeamId = cmbAwayteam.SelectedIndex + 1;
                command.CommandText = "INSERT INTO tblMatches (MatchDate,HomeTeamId,AwayTeamId) VALUES (#" + dtpMatchDate.Value.ToString("yyyy-MM-dd") + "#," + homeTeamId + "," + awayTeamId + ")";
                command.ExecuteNonQuery();
                MessageBox.Show("Match Saved");
                connection.Close();
                PlayerEvent playerEventForm = new PlayerEvent();
                playerEventForm.Show();
                this.Hide();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);

            }

        }

        private void txbMatchDate_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

