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
    public partial class SignupForm : Form
    {
        private UserService _userService;
        public SignupForm(UserService userService)
        {
            InitializeComponent();
            _userService = userService;
        }

        private void iAgree_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = this.iAgree.Checked;
            if (isChecked)
            {
                this.ButtonSignUp.Enabled = true;
            }
            else
            {
                this.ButtonSignUp.Enabled = false;
            }
        }

        private void ShowTerms(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ToolTip termsTooltip = new ToolTip();
            termsTooltip.ToolTipTitle = "Պայմաններ";
            termsTooltip.UseFading = true;
            termsTooltip.IsBalloon = true;
            termsTooltip.AutoPopDelay = 30000;
            termsTooltip.SetToolTip(termsLink, "Ես ընդունում եմ Ձեր ասածը։ Ես քթնվում եմ էդ մոմենդների տակ, \nնույն Ձեր ասածի ներկայիս դրությամբ։ Բայց պետք չի։ \nՄինչեւ աղջկան լիովին չքթնես, որ էդ աղջիկը պետք ա \nքո կյանքում քո ազատ սիրո նկատմամբ պետք ա, \nես էդ հարցերը արդեն մի կողմ եմ դնում։");
        }

        private void ButtonSignUp_Click(object sender, EventArgs e)
        {
            if (this.signupFullName.TextLength < 3 || this.signupUserName.TextLength < 3 || this.signupPassword.TextLength < 6 || this.signupRePassword.TextLength < 6)
            {
                MessageBox.Show("Բոլոր դաշտերը լրացնելը պարտադիր է։ Անունն ու մուտքանունը պետք է պարունակեն առնվազն 3 նիշ, իսկ գաղտնաբառը՝ 6։", "Գրանցումը չհաջողվեց",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
            else if (signupPassword.Text != signupRePassword.Text)
            {
                MessageBox.Show("Մուտքագրված գաղտնաբառերը չեն համընկնում։ Փորձեք նորից։", "Գրանցումը չհաջողվեց",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
            else if (!_userService.CheckDuplicateUsername(signupUserName.Text))
            {
                MessageBox.Show("Մուտքանունն արդեն զբաղված է։", "Գրանցումը չհաջողվեց",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
            else
            {
                _userService.Register(signupFullName.Text, signupUserName.Text, signupPassword.Text);
                MessageBox.Show("Շնորհակալություն գրանցման համար։", "Գրանցումը հաջողվեց",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }

        }
    }
}
