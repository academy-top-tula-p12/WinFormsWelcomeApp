using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsWelcomeApp
{
    public partial class AuthForm : Form
    {
        Form formMain;

        public AuthForm(Form formMain)
        {
            InitializeComponent();
            this.formMain = formMain;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtLogin.Text == "admin" && txtPassword.Text == "admin") 
            {
                formMain.Visible = true;
                this.Close();
            }
        }
    }
}
