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
    public partial class Timeout : Form
    {
        public Timeout()
        {
            InitializeComponent();
            AutoClose(10000);
        }
        private async Task AutoClose(int delay)
        {
            await Task.Delay(delay);
            this.Close();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Timeout_FormClosing(object sender, FormClosingEventArgs e)
        {
          
        }
    }
}
