using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BasketballApp
{
    public partial class Home : Form
    {
        // db connection string for access database
        string connectionString  = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=dbBasketball.accdb;"; // connection string for access database

        public Home()
        {
            InitializeComponent();
        }

        private void btnAddPlayer_Click(object sender, EventArgs e) // opens the AddPlayer form and hides the Home form
        {
            AddPlayer addPlayerForm = new AddPlayer(); // creates a new instance of the AddPlayer form
            addPlayerForm.Show();
            this.Hide(); // opens the AddPlayer form and hides the Home form
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit(); // exits the app completely
        }
    }
}