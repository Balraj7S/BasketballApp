using System.Data.OleDb;
using System.Data;

namespace BasketballApp
{
    public partial class AddPlayer : Form
    {
        OleDbConnection connection = new OleDbConnection();

        public AddPlayer() // loads team names from tblTeams into the ComboBox dropdown for team selection
        {
            InitializeComponent(); // loads the form and initializes the components
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=dbBasketball.accdb;"; // connection string for access database
            connection.Open();
            OleDbCommand command = new OleDbCommand("Select TeamId,TeamName From tblTeams", connection); // selects team names from tblTeams to populate the ComboBox
            OleDbDataReader reader = command.ExecuteReader(); // executes the command and reads the data from the database
            while (reader.Read()) // loops through the data and adds the team names to the ComboBox
            {
                cmbTeamName.Items.Add(reader["TeamName"].ToString()); // adds the team names to the ComboBox
            }
            connection.Close(); // closes the connection to the database
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            // 1. Check if any fields are empty
            if (txbPlayerName.Text == "" || txbPlayerSurname.Text == "" || txbPlayerPosition.Text == "" || cmbTeamName.SelectedIndex == -1) // checks if any of the fields are empty or if no team is selected
            {
                MessageBox.Show("Please fill in all fields!"); // shows a message box if any of the fields are empty
                return;
            }

            // 2. Enforce LETTERS AND SPACES ONLY for Name and Surname (blocks numbers and all symbols)
            if (!System.Text.RegularExpressions.Regex.IsMatch(txbPlayerName.Text, @"^[a-zA-Z\s]+$") || 
                !System.Text.RegularExpressions.Regex.IsMatch(txbPlayerSurname.Text, @"^[a-zA-Z\s]+$")) // checks if the Name and Surname fields contain only letters and spaces
            {
                MessageBox.Show("Player Name and Surname can only contain letters and spaces!"); // shows a message box if the Name and Surname fields contain numbers or symbols
                return;
            }

            // 3. Validate position: check valid basketball positions and letters only
            string pos = txbPlayerPosition.Text.Trim().ToLower();
            string[] validPositions = { "point guard", "shooting guard", "small forward", "power forward", "center", "pg", "sg", "sf", "pf", "c" }; // list of valid basketball positions

            bool isValidPosition = validPositions.Contains(pos);
            bool isLettersOnly = System.Text.RegularExpressions.Regex.IsMatch(txbPlayerPosition.Text, @"^[a-zA-Z\s]+$"); // checks if the Position field contains only letters and spaces

            if (!isLettersOnly || !isValidPosition) // checks if the Position field is valid and contains only letters and spaces
            {
                MessageBox.Show("Invalid position! Please enter a valid basketball position (e.g., Point Guard, Shooting Guard, Small Forward, Power Forward, Center, or PG, SG, SF, PF, C) using letters only."); // shows a message box if the Position field is invalid or contains numbers or symbols
                return;
            }

            try
            {
                if (connection.State == ConnectionState.Open) connection.Close(); // closes the connection if it is already open
                connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=dbBasketball.accdb;"; // sets the connection string for the access database
                connection.Open();

                OleDbCommand command = new OleDbCommand(); // creates a new command object to execute SQL commands
                command.Connection = connection;
                int teamId = cmbTeamName.SelectedIndex + 1; // get the teamId based on the selected index of the ComboBox (assuming TeamId starts from 1)

                command.CommandText = "INSERT INTO tblPlayer ([Name], Surname, [Position], TeamId) VALUES('" + txbPlayerName.Text + "','" + txbPlayerSurname.Text + "','" + txbPlayerPosition.Text + "', " + teamId + ")"; // Use brackets for reserved keywords like Name and Position
                command.ExecuteNonQuery(); // execute the insert command

                command.CommandText = "SELECT @@IDENTITY"; // Use @@IDENTITY to get the last inserted ID for the player
                int playerId = Convert.ToInt32(command.ExecuteScalar()); // get the last inserted playerId

                MessageBox.Show("Player Saved");// show confirmation message
                connection.Close();

                int teamIndex = cmbTeamName.SelectedIndex; // get the selected index of the ComboBox for team selection
                Match matchForm = new Match(playerId, teamId, txbPlayerName.Text, txbPlayerSurname.Text, txbPlayerPosition.Text); // Pass the playerId, teamId, and player details to the Match form
                matchForm.Show(); // open the Match form
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex); // show a message box with the error message if an exception occurs
            }
        }

        public void SetFields(string name, string surname, string positon, int teamIndex) // saves data when coming back from match form
        {
            txbPlayerName.Text = name; // sets the text of the Name textbox to the provided name
            txbPlayerSurname.Text = surname; // sets the text of the Surname textbox to the provided surname
            txbPlayerPosition.Text = positon; // sets the text of the Position textbox to the provided position
            cmbTeamName.SelectedIndex = teamIndex; // sets the selected index of the ComboBox to the provided teamIndex
        }

        private void btnViewPlayer_Click(object sender, EventArgs e) // gets all players to show in grid view
        {
            try
            {
                if (connection.State == ConnectionState.Open) connection.Close(); // closes the connection if it is already open
                connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=dbBasketball.accdb;"; // sets the connection string for the access database
                OleDbCommand command = new OleDbCommand();  // creates a new command object to execute SQL commands
                connection.Open(); // opens the connection to the database
                command.Connection = connection; // sets the connection for the command object to the opened connection
                string query = "SELECT tblPlayer.PlayerId" + // selects player data from tblPlayer along with team names, match dates, and events using INNER JOINs
                    ", tblPlayer.[Name], tblPlayer.Surname, tblTeams.TeamName, tblMatches.MatchDate, tblMatchEvent.[Event] " + // selects the PlayerId, Name, Surname, TeamName, MatchDate, and Event columns from the joined tables
                    "FROM (((tblPlayer " + // joins tblPlayer to tblTeams on TeamId to get the team names associated with each player
                    "INNER JOIN tblTeams ON tblPlayer.TeamId = tblTeams.TeamId) " + // joins tblTeams to tblPlayer on TeamId to get the team names associated with each player
                    "INNER JOIN tblMatchEvent ON tblPlayer.PlayerId = tblMatchEvent.PlayerId) " + // joins tblMatchEvent to tblPlayer on PlayerId to get the events associated with each player
                    "INNER JOIN tblMatches ON tblMatchEvent.MatchId = tblMatches.MatchId)"; // query to retrieve player data along with team names, match dates, and events using INNER JOINs
                command.CommandText = query; // set the command text to the query
                OleDbDataAdapter da = new OleDbDataAdapter(command); // create a data adapter to fill the DataTable with the results of the query
                DataTable dt = new DataTable(); // create a DataTable to hold the results of the query
                da.Fill(dt); // fill the DataTable with the results of the query
                dGVPlayerView.DataSource = dt; // set the DataSource of the DataGridView to the DataTable to display the results
                connection.Close(); // close the connection to the database
            }
            catch (Exception ex) // catch any exceptions that occur during the database operations
            { 
                MessageBox.Show("Error " + ex); // show a message box with the error message if an exception occurs
            }
        }

        private void btnBack_Click(object sender, EventArgs e) // go back to home form
        {
            Home homeForm = new Home();
            homeForm.Show();
            this.Hide();
        }


    }
}
                                                                                          