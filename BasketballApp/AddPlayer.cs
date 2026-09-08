using System.Data.OleDb;
using System.Data;

namespace BasketballApp
{
    public partial class AddPlayer : Form
    {
        OleDbConnection connection = new OleDbConnection();

        public AddPlayer()
        {
            InitializeComponent();
            connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\dbBasketball.accdb";
            connection.Open();
            OleDbCommand command = new OleDbCommand("Select TeamId,TeamName From tblTeams", connection);
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                cmbTeamName.Items.Add(reader["TeamName"].ToString());

            }
            connection.Close();
        }


        private void btnNext_Click(object sender, EventArgs e)
        {
            if (txbPlayerName.Text == "" || txbPlayerSurname.Text == "" || txbPlayerPosition.Text == "" || cmbTeamName.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all fields!");
                return;
            }


            try
            {
                if (connection.State == ConnectionState.Open) connection.Close();
                connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\dbBasketball.accdb";
                OleDbCommand command = new OleDbCommand();
                connection.Open();
                command.Connection = connection;
                int teamId = cmbTeamName.SelectedIndex + 1;
                command.CommandText = "INSERT INTO tblPlayer ([Name],Surname, [Position],TeamId) VALUES('" + txbPlayerName.Text + "','" + txbPlayerSurname.Text + "','" + txbPlayerPosition.Text + "', '" + teamId + "')";
                command.ExecuteNonQuery();
                command.CommandText = "SELECT @@IDENTITY";
                int playerId = Convert.ToInt32(command.ExecuteScalar());
                MessageBox.Show("Player Saved");
                connection.Close();
                Match matchForm = new Match(playerId,teamId);
                matchForm.Show();
                this.Hide();  
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);

            }


        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void lblPlayerPosition_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddPlayer_Load(object sender, EventArgs e)
        {




        }
     

        private void btnViewPlayer_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection.State == ConnectionState.Open) connection.Close();
                connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\dbBasketball.accdb";
                OleDbCommand command = new OleDbCommand();
                connection.Open();
                command.Connection = connection;
                string query = "SELECT tblPlayer.PlayerId, tblPlayer.[Name], tblPlayer.Surname, tblPlayer.[Position], tblTeams.TeamName FROM tblPlayer INNER JOIN tblTeams On tblPlayer.TeamID = tblTeams.TeamId";
                command.CommandText = query;
                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                connection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error" + ex);

            }


        }
    }
}
                                                                                          