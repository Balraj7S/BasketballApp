
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
                connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\\\filesrvr01\\home\\balrsing\\My Documents\\Projects\\BasketballApp\\BasketballApp\\dbBasketball.accdb;";
                connection.Open();
                OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM tblPlayer", connection);
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
            HomeForm homeForm = new HomeForm();
            homeForm.Show();
            this.Hide();
            
        }
    }
}
