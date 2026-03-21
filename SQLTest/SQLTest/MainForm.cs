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
    public partial class MainForm: Form
    {
        PgUsersLoader pgUsersLoader = new PgUsersLoader();
        public MainForm()
        {
            InitializeComponent();
            BindingList<User> users = pgUsersLoader.Load();
            userDataGridView.DataSource = users;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = userDataGridView.SelectedRows[0];
            User user = row.DataBoundItem as User;
            pgUsersLoader.DeleteUser(user.Login);
        }
    }
}
