
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
    public partial class Finish : Form
    {
        OleDbConnection connection = new OleDbConnection();

        public Finish() // Calss LoadData() automatically when Finish form opens
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData() // Retreives all player data from tblPlayer using SELECT query
                                // Displays result in DataGrtidView form coach to view
        {
            try
            {
                if (connection.State == ConnectionState.Open) connection.Close(); // closes the connection if it is already open
                connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=dbBasketball.accdb;"; // sets the connection string for the access database
                connection.Open(); // opens the connection to the database
                string query = "SELECT tblPlayer.PlayerId" + // selects player data from tblPlayer along with team names, match dates, and events using INNER JOINs
                    ", tblPlayer.[Name], tblPlayer.Surname, tblTeams.TeamName, tblMatches.MatchDate, tblMatchEvent.[Event] " + // selects the PlayerId, Name, Surname, TeamName, MatchDate, and Event columns from the joined tables
                    "FROM (((tblPlayer " + // joins tblPlayer to tblTeams on TeamId to get the team names associated with each player
                    "INNER JOIN tblTeams ON tblPlayer.TeamId = tblTeams.TeamId) " + // joins tblTeams to tblPlayer on TeamId to get the team names associated with each player
                    "INNER JOIN tblMatchEvent ON tblPlayer.PlayerId = tblMatchEvent.PlayerId) " + // joins tblMatchEvent to tblPlayer on PlayerId to get the events associated with each player
                    "INNER JOIN tblMatches ON tblMatchEvent.MatchId = tblMatches.MatchId)"; // query to retrieve player data along with team names, match dates, and events using INNER JOINs

                OleDbDataAdapter da = new OleDbDataAdapter(query, connection); // creates a data adapter to fill the DataTable with the results of the query
                DataTable dt = new DataTable(); // creates a DataTable to hold the results of the query
                da.Fill(dt); // fills the DataTable with the results of the query
                dGVSummary.DataSource = dt; // sets the DataSource of the DataGridView to the DataTable to display the results
                connection.Close(); // closes the connection to the database
            }
            catch (Exception ex) // catches any exceptions that occur during the database operations
            {
                MessageBox.Show("Error:" + ex); // shows a message box with the error message if an exception occurs
            }
        }

        private void btnBack_Click(object sender, EventArgs e) // return user to Home form
        {
            Home homeForm = new Home(); // creates a new instance of the Home form
            homeForm.Show(); // shows the Home form to allow the user to return to the main menu
            this.Hide(); // hides the current Finish form to prevent the user from interacting with it while returning to the main menu
        }

        private void btnAddnewPlayer_Click(object sender, EventArgs e) // Takes user to add new player
        {
            AddPlayer addPlayerForm = new AddPlayer(); // creates a new instance of the AddPlayer form
            addPlayerForm.Show();// shows the AddPlayer form to allow the user to add a new player
            this.Hide();// hides the current Finish form to prevent the user from interacting with it while adding a new player
        }

      
    }
}
