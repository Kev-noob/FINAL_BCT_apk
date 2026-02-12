using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FINAL_BCT_apk
{
    public partial class Super_admin : Form
    {
        public Super_admin()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //LOG OUT
            login_signin_form loginForm = new login_signin_form();
            this.Hide();
            loginForm.Show();
        }
    }
}
