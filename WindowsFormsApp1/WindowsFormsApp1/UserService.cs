using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class UserService
    {
        private IUserStore _store;
        public UserService(IUserStore store)
        {
            _store = store;
        }
        public User Register(string fullName, string username, string password)
        {
            User user = new User()
            {
                _fullName = fullName,
                _username = username,
                _password = Encrypt(password)
            };
            _store.AddUser(user);
            return user;
        }
        public bool Check(string username, string password)
        {
            var user = _store.GetUsers().Where(x => x._username.ToLower() == username && x._password == Encrypt(password)).FirstOrDefault();
            return user != null;
        }
        public bool CheckDuplicateUsername(string username)
        {
            bool noSuchUsername = true;
            for (int i = 0; i < _store.GetUsers().Count; i++)
            {
                if (username == _store.GetUsers()[i]._username.ToLower())
                {
                    noSuchUsername = false;
                }
            }
            return noSuchUsername;
        }
        public bool UserExists(string username)
        {
            bool usernameExists = false;
            for (int i = 0; i < _store.GetUsers().Count; i++)
            {
                if (username == _store.GetUsers()[i]._username.ToLower())
                {
                    usernameExists = true;
                }
            }
            return usernameExists;
        }
        private string Encrypt(string password)
        {
            byte[] data = System.Text.Encoding.ASCII.GetBytes(password);
            data = new System.Security.Cryptography.SHA256Managed().ComputeHash(data);
            String hash = System.Text.Encoding.ASCII.GetString(data);
            return Convert.ToBase64String(data);
        }

    }
}
