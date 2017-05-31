using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class FileUserStore : IUserStore
    {
        private List<User> _users = new List<User>();

        public void AddUser(User user)
        {
                _users.Add(user);
                WriteToFile(user, _users.Count);            
        }
        public List<User> GetUsers()
        {
            return _users;
        }

        public void FromFileToList()
        {
            int lineCount = File.ReadLines("users.toplabs").Count();
            StreamReader file = new StreamReader("users.toplabs");

            for (int i = 0; i < lineCount; i++)
            {
                string[] fields = file.ReadLine().Split(':');
                try
                {
                    _users.Add(new User() { _fullName = fields[1], _username = fields[2], _password = fields[3] });
                }
                catch (Exception err)
                {
                    File.AppendAllText("errorlog.toplabs", $"Error ({DateTime.Now}): {err}\n");
                }
            }
            file.Close();

        }

        public void WriteToFile(User user, int id)
        {
            File.AppendAllText("users.toplabs", $"\n{id}:{user._fullName}:{user._username}:{user._password}");
            
            string readText = File.ReadAllText("users.toplabs");
        }
    }
}
