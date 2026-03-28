using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFileStorage
{
    class PgUsersStorage : IUsersInterface
    {
        List<User> allUsers = new List<User>();
        public List<User> Load()
        {
            var cs = "Host=192.168.1.48;Username=st56-10;Password=5610;Database=DbforPM_OlgaSafonova";
            var con = new NpgsqlConnection(cs);
            con.Open();
            var sql = @"SELECT login, password FROM users";
            var cmd = new NpgsqlCommand(sql, con);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                User user = new User(reader.GetString(0), reader.GetString(1));
                allUsers.Add(user);
            }
            return allUsers;
        }

        public bool UserRegistration(User us)
        {
            var cs = "Host=192.168.1.48;Username=st56-10;Password=5610;Database=DbforPM_OlgaSafonova";
            var con = new NpgsqlConnection(cs);
            con.Open();
            var sql = @"INSERT INTO users (login, password) VALUES (@login, @password)";
            var cmd = new NpgsqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@login", us.Login);
            cmd.Parameters.AddWithValue("@password", us.Password);
            int execute = cmd.ExecuteNonQuery();
            if (execute > 0)
            {
                allUsers.Add(us);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool UserVerification(string login)
        {
            var cs = "Host=192.168.1.48;Username=st56-10;Password=5610;Database=DbforPM_OlgaSafonova";
            var con = new NpgsqlConnection(cs);
            con.Open();
            var sql = @"SELECT FROM users WHERE login = @login";
            var cmd = new NpgsqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@login", login);
            var res = cmd.ExecuteNonQuery();
            if (res > 1)
            {
                return true;
            }
            return false;
        }
    }
}
