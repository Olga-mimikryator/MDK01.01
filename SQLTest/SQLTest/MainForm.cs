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

        private void buttonClear_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите очистить пользовательскую базу?", "Внимание", MessageBoxButtons.OKCancel);
            if(result == DialogResult.OK)
            {
                pgUsersLoader.ClearUsers();
            }
        }

        private void buttonUserAdd_Click(object sender, EventArgs e)
        {
            AddOrEditUser addOrEditUser = new AddOrEditUser();
            addOrEditUser.Show();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            AddOrEditUser addOrEditUser = new AddOrEditUser();
            addOrEditUser.Show();
            
        }
    }
}
