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
    public partial class HomeForm : Form

    {
        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = ""\\filesrvr01\home\balrsing\My Documents\Projects\BasketballApp\BasketballApp\dbBasketball.accdb";
        public HomeForm()
        {
            InitializeComponent();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {


        }

        private void bntAddPlayer_Click(object sender, EventArgs e)
        {
            AddPlayer addPlayerForm = new AddPlayer();
            addPlayerForm.Show();
            this.Hide();

        }
    }
}
