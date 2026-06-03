using System.Data.OleDb;

namespace BasketballApp
{
    public partial class AddPlayer : Form
    {
        OleDbConnection connection = new OleDbConnection();
        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = ""\\filesrvr01\home\balrsing\My Documents\Projects\BasketballApp\BasketballApp\dbBasketball.accdb";
      
        public AddPlayer()

        {
            InitializeComponent();

        }


        private void btnNext_Click(object sender, EventArgs e)
        {
            try{
                OleDbCommand command = new OleDbCommand();
                connection.Open();
                command.Connection = connection;
                command.CommandText = 
                
            }
            catch {


            }
        }
    }
}
