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
    public partial class SecondForm : Form
    {
        private string userName;
        public string UserName 
        {
            get { return userName; }
            set { userName = value;
                nameLb.Text = $"Hello, dear {userName}";
            } 
        }
        public SecondForm()
        {
            InitializeComponent();
        }
        public SecondForm(string name)
        {
            InitializeComponent();
            UserName = name;            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show($"User name : {UserName}");
        }

        public void Show(string name)
        {
            UserName = name;
            this.Show();    
        }
    }
}
