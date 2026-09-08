
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

        public Finish()
        {   
            
            
            InitializeComponent(); 
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                if (connection.State == ConnectionState.Open) connection.Close();
                connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\dbBasketball.accdb";
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "SELECT tblPlayer.[Name], tblPlayer.Surname, tblTeams.TeamName " +
                            "FROM tblPlayer " +
                             "INNER JOIN tblTeams ON tblPlayer.TeamId = tblTeams.TeamId";
                            // "INNER JOIN tblMatchEvent ON tblPlayer.PlayerId = tblMatchEvent.PlayerId";


                //"SELECT tblPlayer.[Name], tblPlayer.Surname, tblTeams.TeamName, tblMacthes.MatchDate, tblMatchEvent.[Event]" +
                // "FROM ((tblPlayer " +
                // "INNER JOIN tblTeams ON tblPlayer.TeamId = tblTeams.TeamId)" +
                // "INNER JOIN tblMatchEvent ON tblPlayer.PlayerId = tblMatchEvent.PlayerId)" +
                // "INNER JOIN tblMatches ON tblMatchEvent.MatchId = tblMatches.MatchId";
                command.CommandText = query;
                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex);
            }

        }

        private void Finish_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            
        }
    }
}
