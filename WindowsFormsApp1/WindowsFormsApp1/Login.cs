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
    public partial class LoginForm : Form
    {
        private UserService _userService;
        public LoginForm(UserService userService)
        {
            InitializeComponent();
            _userService = userService;
        }
        private void InputLimit()
        {
            DisableControls(10000);
            Timeout timeout = new Timeout();
            timeout.ShowDialog();            
            _numberOfInputs = 0;
        }

        private async Task DisableControls(int delay)
        {
            this.Enabled = false;
            await Task.Delay(delay);
            this.Enabled = true;
        }

        private int _numberOfInputs = 0;
        private void button1_Click(object sender, EventArgs e)
        {            
            bool grantAccess = _userService.Check(loginUsername.Text.ToLower(), loginPassword.Text);
            if (grantAccess)
            {
                MessageBox.Show("Բարի գալուստ։", "Մուտքը հաջողվեց", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                Application.Exit();
            }
            else
            {
                _numberOfInputs++;
                var err = MessageBox.Show("Մուտքագրված է սխալ օգտվողի անուն կամ գաղտնաբառ։", "Մուտքը չհաջողվեց",
                    MessageBoxButtons.RetryCancel,
                    MessageBoxIcon.Error);
                if (_numberOfInputs > 5)
                {
                    InputLimit();
                }
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
            if (loginUsername.Text.Length > 0)
            {
                this.loginPassword.Enabled = true;
            }
            else
            {
                this.loginPassword.Enabled = false;
            }
        }

        private void usernameLostFocus(object sender, EventArgs e)
        {
        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordLeave(object sender, EventArgs e)
        {
            bool grantAccess = _userService.Check(loginUsername.Text.ToLower(), loginPassword.Text);
            if (grantAccess)
            {
                passwordOK.Visible = true;
            }
            else
            {
                passwordWrong.Visible = true;
                _numberOfInputs++;
                if (_numberOfInputs > 5)
                {
                    InputLimit();
                }
            }
        }

        private void password_TextChanged_1(object sender, EventArgs e)
        {
            

            passwordWrong.Visible = false;
            passwordOK.Visible = false;
        }

        private void openSignUp(object sender, EventArgs e)
        {
            SignupForm signupForm = new SignupForm(_userService);
            signupForm.ShowDialog();
        }
        private void passwordGotFocus(object sender, EventArgs e)
        {
            if (_userService.UserExists(loginUsername.Text.ToLower()))
            {
                usernameOK.Visible = true;
            }
            else
            {
                usernameWrong.Visible = true;
            }
        }

        private void loginPassword_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void loginPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.button1_Click(sender, e);
            }
        }
    }
}
