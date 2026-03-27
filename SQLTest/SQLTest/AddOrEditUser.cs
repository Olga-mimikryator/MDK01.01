using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLTest
{
    public partial class AddOrEditUser: Form
    {
        PgUsersLoader pgUsersLoader = new PgUsersLoader();
        public AddOrEditUser()
        {
            InitializeComponent();
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Добавить нового пользователя в базу?", "Внимание", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                User newUserForAdd = new User
                {
                    Login = textBoxLogin.Text,
                    Password = textBoxPassw.Text,
                    Age = (int)numericUpDownAge.Value,
                    Name = textBoxName.Text
                };
                pgUsersLoader.AddUser(newUserForAdd);
                this.Close();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
