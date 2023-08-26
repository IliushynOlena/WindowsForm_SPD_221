using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08_AdditionalForms
{
    public partial class LoginForm : Form
    {
        public LoginInfo LoginInfo { get; set; }
        public LoginForm()
        {
            InitializeComponent();
            LoginInfo = new LoginInfo();
        }
        public LoginForm(LoginInfo info)
        {
            InitializeComponent();
            LoginInfo = info;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void loginBtnClick(object sender, EventArgs e)
        {
            //LoginInfo = new LoginInfo()
            //{
            //    Login = loginTb.Text,
            //    Password = PasswordTb.Text
            //};

            if(string.IsNullOrWhiteSpace(loginTb.Text) || 
                string.IsNullOrWhiteSpace(PasswordTb.Text))
            {
                MessageBox.Show("Enter login or password");return;
            }

            LoginInfo.Login = loginTb.Text;
            LoginInfo.Password = PasswordTb.Text;
 
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
