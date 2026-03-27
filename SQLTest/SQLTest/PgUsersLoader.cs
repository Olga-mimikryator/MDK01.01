using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLTest
{
    public class PgUsersLoader
    {
        BindingList<User> users = new BindingList<User>();
        public BindingList<User> Load()
        {
            try
            {
                var cs = "Host=192.168.1.48;Username=st56-10;Password=5610;Database=DbforPM_OlgaSafonova";

                var con = new NpgsqlConnection(cs);
                con.Open();
                var sql = "SELECT login,password,age,name FROM users";
                var cmd = new NpgsqlCommand(sql, con);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    User user = new User
                    {
                        Login = reader.GetString(0),
                        Password = reader.GetString(1),
                        Age = reader.GetInt32(2),
                        Name = reader.GetString(3),
                    };
                    users.Add(user);
                }
                return users;
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
                return null;
            }
        }

        public bool DeleteUser(string login)
        {
            try
            {
                bool result = true;
                var cs = "Host=192.168.1.48;Username=st56-10;Password=5610;Database=DbforPM_OlgaSafonova";
                var con = new NpgsqlConnection(cs);
                con.Open();
                var sql = @"DELETE FROM users WHERE login = @login";
                var cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@login", login);

                for (int index=0; index < users.Count; ++index)
                {
                    if (users[index].Login == login)
                    {
                        users.RemoveAt(index);
                        --index;
                    }
                }

                if(cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
                return false;
            }
        }

        public bool ClearUsers()
        {
            try
            {
                bool result = true;
                var cs = "Host=192.168.1.48;Username=st56-10;Password=5610;Database=DbforPM_OlgaSafonova";
                var con = new NpgsqlConnection(cs);
                con.Open();
                var sql = @"DELETE FROM users";
                var cmd = new NpgsqlCommand(sql, con);
                int execute = cmd.ExecuteNonQuery();

                if(execute > 0)
                {
                    result = true;
                }
                users.Clear();
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
                return false;
            }
        }

        public bool AddUser(User newUser)
        {
            try
            {
                bool result = true;
                var cs = "Host=192.168.1.48;Username=st56-10;Password=5610;Database=DbforPM_OlgaSafonova";
                var con = new NpgsqlConnection(cs);
                con.Open();
                var sql = @"INSERT INTO users (login, password, age, name) VALUES (@login, @password, @age, @name)";
                var cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@login", newUser.Login);
                cmd.Parameters.AddWithValue("@password", newUser.Password);
                cmd.Parameters.AddWithValue("@age", newUser.Age);
                cmd.Parameters.AddWithValue("@name", newUser.Name);
                int execute = cmd.ExecuteNonQuery();
                if (execute > 0)
                {
                    result = true;
                }
                users.Add(newUser);
                return false;
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
                return false;
            }
        }

        public bool EditUser(string login)
        {
            try
            {
                bool result = true;
                var cs = "Host=192.168.1.48;Username=st56-10;Password=5610;Database=DbforPM_OlgaSafonova";
                var con = new NpgsqlConnection(cs);
                con.Open();
                var sql = @"UPDATE users SET password = @password, age = @age, name = @name WHERE login = @login";
                var cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@login", login);
                //cmd.Parameters.AddWithValue("@password", Password);
                //cmd.Parameters.AddWithValue("@age", Age);
                //cmd.Parameters.AddWithValue("@name", Name);
                int execute = cmd.ExecuteNonQuery();
                if (execute > 0)
                {
                    result = true;
                }

                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
                return false;
            }
        }

    }
}
