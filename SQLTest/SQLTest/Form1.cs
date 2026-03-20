using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace SQLTest
{
    public partial class Form1: Form
    {
        PgUsersLoader pgUsersLoader = new PgUsersLoader();
        public Form1()
        {
            InitializeComponent();
            List<User> users = pgUsersLoader.Load();
            userDataGridView.DataSource = users;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
