using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        internal string _username = "Rammstein";
        internal string _password = "Awet";
        //public List<User> usersList = new List<User>();
        //public User newUser(string username, string password)
        //{
        //    var user = new User(username, password);
        //    usersList.Add(user);            
        //    newUser("Rammstein", "Awet");
        //    newUser("Aram", "Kocharyan");
        //    return user;
        //}

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool checkbox = this.iAgree.Checked;
            if (checkbox == true)
            {
                this.Size = new Size(300, 325);
                this.button1.Visible = true;
            }
            if (checkbox == false)
            {
                this.Size = new Size(300, 150);
                this.button1.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = this.username.Text.ToLower();
            string password = this.password.Text;
            bool isChecked = this.iAgree.Checked;

            if (username == _username.ToLower() && password == _password && isChecked)
            {
                MessageBox.Show("Բարի գալուստ։", "Մուտքը հաջողվեց", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                Application.Exit();
            }
            else if (!isChecked)
            {
                MessageBox.Show("Դուք չեք ընդունել պայմանները։", "Մուտքը չհաջողվեց");
            }
            else
            {
                var err = MessageBox.Show("Մուտքագրված է սխալ օգտվողի անուն կամ գաղտնաբառ։", "Մուտքը չհաջողվեց",
                    MessageBoxButtons.RetryCancel,
                    MessageBoxIcon.Error);
                if (err == DialogResult.Cancel)
                {
                    Application.Exit();
                }
            }
        }

        private void username_TextChanged(object sender, EventArgs e)
        {
            this.usernameWrong.Visible = false;
            this.usernameOK.Visible = false;
            if (username.Text.Length > 0)
            {
                this.password.Enabled = true;
                this.iAgree.Enabled = true;
            }
            else
            {
                this.password.Enabled = false;
                this.iAgree.Enabled = false;
            }
        }

        private void usernameLeave(object sender, EventArgs e)
        {
            string username = this.username.Text.ToLower();
            if (username == _username.ToLower())
            {
                this.usernameOK.Visible = true;
            }
            else
            {
                this.usernameWrong.Visible = true;
                this.username.Focus();
                this.username.SelectionStart = 0;
                this.username.SelectionLength = username.Length;
                MessageBox.Show("Սխալ օգտվողի անուն։");
            }
            //bool success = false;
            //int count = usersList.Count;
            //MessageBox.Show(Convert.ToString(count));
            //for (int i = 0; i < count; i++)
            //{
            //    if (username == usersList[i]._username)
            //    {
            //        this.usernameOK.Visible = true;
            //        success = true;
            //    }
            //}
            //if (success == false)
            //{
            //    this.usernameWrong.Visible = true;
            //    this.username.Focus();
            //    this.username.SelectionStart = 0;
            //    this.username.SelectionLength = username.Length;
            //    MessageBox.Show("Սխալ օգտվողի անուն։");
            //}
        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordLeave(object sender, EventArgs e)
        {
            string password = this.password.Text;
            if (password != _password)
            {
                this.passwordWrong.Visible = true;
                MessageBox.Show("Սխալ գաղտնաբառ։");
            }
            else
            {
                this.passwordOK.Visible = true;
            }
        }

        private void password_TextChanged_1(object sender, EventArgs e)
        {
            this.passwordWrong.Visible = false;
            this.passwordOK.Visible = false;
        }
        
    }
    
        //public class User
        //{
        //    public string _username { get; set; }
        //    public string _password { get; set; }
        //    public User(string username, string password)
        //    {
        //        _username = username;
        //        _password = password;
        //    }
        //}
}
