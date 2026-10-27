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
        int homeTeamIndex;
        int awayTeamIndex;
        string storedMatchDate; // saved date variable

        public MatchEvent(int pId, int mId, int tId, int homeIdx, int awayIdx) // Stores playerId, matchId and teamId passed
        {
            InitializeComponent(); // initializes the form components
            playerId = pId; // stores the playerId passed from Match form
            matchId = mId; // stores the matchId passed from Match form
            teamId = tId; // stores the teamId passed from Match form
            homeTeamIndex = homeIdx; // stores the home team index passed from Match form
            awayTeamIndex = awayIdx; // stores the away team index passed from Match form

            connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\\\filesrvr01\\home\\balrsing\\My Documents\\Projects\\BasketballApp\\BasketballApp\\dbBasketball.accdb;"; // sets the connection string for the access database
            connection.Open(); // opens the connection to the database
            connection.Close(); // closes the connection to the database
        }

        private void InitializeComponent()
        {
            lblAddPlayerEvent = new Label();
            txbMatchEvent = new TextBox();
            btnBack = new Button();
            bntNext = new Button();
            SuspendLayout();
            // 
            // lblAddPlayerEvent
            // 
            lblAddPlayerEvent.AutoSize = true;
            lblAddPlayerEvent.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAddPlayerEvent.Location = new Point(188, 191);
            lblAddPlayerEvent.Name = "lblAddPlayerEvent";
            lblAddPlayerEvent.Size = new Size(130, 21);
            lblAddPlayerEvent.TabIndex = 0;
            lblAddPlayerEvent.Text = "Add Player Event:";
            // 
            // txbMatchEvent
            // 
            txbMatchEvent.Location = new Point(339, 189);
            txbMatchEvent.Name = "txbMatchEvent";
            txbMatchEvent.Size = new Size(200, 23);
            txbMatchEvent.TabIndex = 1;
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
            bntNext.Click += btnNext_Click;
            // 
            // MatchEvent
            // 
            ClientSize = new Size(837, 469);
            Controls.Add(bntNext);
            Controls.Add(btnBack);
            Controls.Add(txbMatchEvent);
            Controls.Add(lblAddPlayerEvent);
            Name = "MatchEvent";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblAddPlayerEvent;


        private TextBox txbMatchEvent;
        private Button btnBack;

        private Button bntNext;
        private void btnNext_Click(object sender, EventArgs e) // Saves match event to tblMatchEvent and returns user to Finish form
        {
            try
            {
                if (txbMatchEvent.Text == "") // checks if the match event textbox is empty
                {
                    MessageBox.Show("Please enter an event!"); // shows a message box if the match event textbox is empty
                    return;
                }

                if (!System.Text.RegularExpressions.Regex.IsMatch(txbMatchEvent.Text, @"^[a-zA-Z0-9\s]+$")) // checks if the match event textbox contains only letters, numbers,and spaces
                 {
                    MessageBox.Show("Match event can only contain letters, nunbers and spaces!");// shows a nessage box If the match event textbox contains symbols!
                    return;
                }

                 
                if (connection.State == ConnectionState.Open) connection.Close(); // closes the connection if it is already open
                connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\\\filesrvr01\\home\\balrsing\\My Documents\\Projects\\BasketballApp\\BasketballApp\\dbBasketball.accdb;"; // sets the connection string for the access database
                OleDbCommand command = new OleDbCommand(); // creates a new command object to execute SQL commands
                connection.Open(); // opens the connection to the database
                command.Connection = connection; // sets the connection for the command object

                command.CommandText = "INSERT INTO tblMatchEvent (PlayerId, MatchId, Event) VALUES (" + playerId + "," + matchId + ",'" + txbMatchEvent.Text + "')"; // inserts a new match event record into tblMatchEvent with the playerId, matchId, and event description
                command.ExecuteNonQuery(); // executes the insert command to save the match event record to the database

                MessageBox.Show("Event Saved!"); // shows a message box confirming that the match event has been saved
                connection.Close(); // closes the connection to the database

                Finish finishForm = new Finish(); // creates a new instance of the Finish form
                finishForm.Show(); // shows the Finish form to allow the user to view the summary of players and events
                this.Hide(); // hides the current MatchEvent form to prevent the user from interacting with it while viewing the summary
            }
            catch (Exception ex) // catch any exceptions that occur during the database operations
            {
                MessageBox.Show("Error " + ex); // shows a message box with the error message if an exception occurs during the database operations
            }
        }

        private void btnBack_Click(object sender, EventArgs e) // Return user to Match form 
        {
            Match matchForm = new Match(playerId, teamId, "", "", ""); // creates a new instance of the Match form and passes the playerId, teamId, and empty strings for player details to the constructor
            matchForm.SetMatchFields(homeTeamIndex, awayTeamIndex); // sets the selected indices of the home and away team ComboBoxes in the Match form to the stored values
            matchForm.Show(); // shows the Match form to allow the user to edit match details
            this.Hide(); // hides the current MatchEvent form to prevent the user from interacting with it while editing match details
        }
    }
}