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
        int playerId;
        int teamId;
        int storedTeamIndex;
        string storedName, storedSurname, storedPosition;

        public Match(int playerId, int teamId, string name, string surname, string position) // loads team names into both ComboBoxes and pre selects the player's house team as home team / stored all the data even after pressing the back button
        {
            InitializeComponent(); // initializes the form components
            selectedTeamId = teamId; // stores the teamId passed from AddPlayer form
            this.playerId = playerId; // stores the playerId passed from AddPlayer form
            storedName = name; // stores the name passed from AddPlayer form
            storedSurname = surname; // stores the surname passed from AddPlayer form
            storedPosition = position; // stores the position passed from AddPlayer form
            storedTeamIndex = selectedTeamId - 1; // stores the team index for the ComboBox selection (assuming TeamId starts from 1)
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=dbBasketball.accdb;"; // sets the connection string for the access database
            connection.Open(); // opens the connection to the database
            OleDbCommand command = new OleDbCommand("SELECT TeamId,TeamName FROM tblTeams", connection); // selects team names from tblTeams to populate the ComboBoxes
            OleDbDataReader reader = command.ExecuteReader(); // executes the command and reads the data from the database

            while (reader.Read()) // loops through the data and adds the team names to both ComboBoxes
            {
                cmbHomeTeam.Items.Add(reader["TeamName"].ToString()); // adds the team names to the home team ComboBox
                cmbAwayTeam.Items.Add(reader["TeamName"].ToString()); // adds the team names to the away team ComboBox
            }
            connection.Close(); // closes the connection to the database
            cmbHomeTeam.SelectedIndex = selectedTeamId - 1; // pre-selects the player's house team as the home team in the ComboBox (assuming TeamId starts from 1)
        }

        private void btnBack_Click(object sender, EventArgs e) // Return user to AddPlayer form while also storing all the data
        {
            AddPlayer addPlayerForm = new AddPlayer();
            addPlayerForm.SetFields(storedName, storedSurname, storedPosition, storedTeamIndex);
            addPlayerForm.Show();
            this.Hide();
        }

        private void btnNext_Click(object sender, EventArgs e) // Validates teams are selected and not the same, saves match to tblMatches
        {
            if (dtpMatchDate.Value.Date > DateTime.Today) // checks if the selected match date is in the future
            {
                MessageBox.Show("Match date must be in the past!"); // shows a message box if the selected match date is in the future
                return;
            }
            if (cmbHomeTeam.SelectedIndex == -1 || cmbAwayTeam.SelectedIndex == -1) // checks if both teams are selected in the ComboBoxes
            {
                MessageBox.Show("Please select both teams!"); // shows a message box if either team is not selected
                return; // exits the method if either team is not selected
            }
            if (cmbHomeTeam.SelectedIndex == cmbAwayTeam.SelectedIndex) // checks if the same team is selected for both home and away teams
            {
                MessageBox.Show("Home and Away Team cannot be the same! Please select different teams."); // shows a message box if the same team is selected for both home and away teams
                return;
            }

            try
            {
                if (connection.State == ConnectionState.Open) connection.Close(); // closes the connection if it is already open
                connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=dbBasketball.accdb;"; // sets the connection string for the access database
                OleDbCommand command = new OleDbCommand(); // creates a new command object to execute SQL commands
                connection.Open();// opens the connection to the database
                command.Connection = connection; // sets the connection for the command object
                int homeTeamId = cmbHomeTeam.SelectedIndex + 1;// gets the home teamId based on the selected index of the ComboBox (assuming TeamId starts from 1)
                int awayTeamId = cmbAwayTeam.SelectedIndex + 1; // gets the away teamId based on the selected index of the ComboBox (assuming TeamId starts from 1)
                command.CommandText = "INSERT INTO tblMatches (MatchDate, HomeTeamId, AwayTeamId) VALUES (#" + dtpMatchDate.Value.ToString("yyyy-MM-dd") + "#," + homeTeamId + "," + awayTeamId + ")"; // inserts a new match record into tblMatches with the selected date, home teamId, and away teamId
                command.ExecuteNonQuery(); // executes the insert command to save the match record to the database
                command.CommandText = "SELECT @@IDENTITY"; // retrieves the last inserted MatchId from tblMatches
                int matchId = Convert.ToInt32(command.ExecuteScalar()); // executes the command and converts the result to an integer to get the new MatchId
                MessageBox.Show("Match Saved");//   shows a message box confirming that the match has been saved]
                connection.Close(); // closes the connection to the database
                MatchEvent MatchEventForm = new MatchEvent(playerId, matchId, teamId, cmbHomeTeam.SelectedIndex, cmbAwayTeam.SelectedIndex); // creates a new instance of the MatchEvent form and passes the playerId, matchId, teamId, and selected indices of the home and away teams to the constructor
                MatchEventForm.Show(); // shows the MatchEvent form to allow the user to enter match events
                this.Hide();// hides the current Match form to prevent the user from interacting with it while entering match events
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex); // shows a message box with the error message if an exception occurs during the database operations
            }
        }

        public void SetMatchFields(int homeIdx, int awayIdx) // sets combo boxes back when coming back from match event form
        {
            cmbHomeTeam.SelectedIndex = homeIdx; // sets the selected index of the home team ComboBox to the provided homeIdx
            cmbAwayTeam.SelectedIndex = awayIdx; // sets the selected index of the away team ComboBox to the provided awayIdx
        }
    
    }
}

