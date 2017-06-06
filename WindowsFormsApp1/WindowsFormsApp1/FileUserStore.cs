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
        public const char Separator = ((char)007);
        public void AddUser(User user)
        {
                _users.Add(user);
                WriteToFile(user, _users.Count);            
        }
        public List<User> GetUsers()
        {
            return _users;
        }
        public FileUserStore()
        {
            FromFileToList();
        }

        public void FromFileToList()
        {
            if (File.Exists("users.toplabs"))
            {
                int lineCount = File.ReadLines("users.toplabs").Count();
                StreamReader file = new StreamReader("users.toplabs");
            for (int i = 0; i < lineCount; i++)
            {
                string[] fields = file.ReadLine().Split(Separator);
                if (fields.Length < 3)
                {
                    continue;
                }                
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
        }

        public string Encrypt(string password)
        {
            byte[] data = System.Text.Encoding.ASCII.GetBytes(password);
            data = new System.Security.Cryptography.SHA256Managed().ComputeHash(data);
            String hash = System.Text.Encoding.ASCII.GetString(data);
            return Convert.ToBase64String(data);
        }

        public void WriteToFile(User user, int id)
        {
            File.AppendAllText("users.toplabs", $"\n{id}{Separator}{user._fullName}{Separator}{user._username}{Separator}{user._password}");
            
            string readText = File.ReadAllText("users.toplabs");
        }
    }
}
