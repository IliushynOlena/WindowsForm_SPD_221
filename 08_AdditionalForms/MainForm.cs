namespace _08_AdditionalForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Open Form
            //SecondForm secondForm = new SecondForm();
            //secondForm.Show();//in nomodal mode
            //secondForm.ShowDialog();//in modal mode

            //Send Data from Parent to Child
            //1 - using constructor
            string name = nameTb.Text;
            //SecondForm secondForm = new SecondForm(name);
            //secondForm.Show();

            //2 - using property
            //SecondForm secondForm = new SecondForm();
            //secondForm.UserName = name;
            //secondForm.Show();

            //3 - using custom Show/ShowDialog method
            SecondForm secondForm = new SecondForm();
            secondForm.Show(name);




        }

        private void button2_Click(object sender, EventArgs e)
        {
            //LoginInfo loginInfo = null; 
            //LoginForm login = new LoginForm();
            //if( login.ShowDialog() == DialogResult.OK )
            //{
            //    //1 - using child form properties
            //    //login.Login
            //    loginInfo = login.LoginInfo;
            //    loginLb.Text = loginInfo.Login;
            //    passwordLb.Text = loginInfo.Password;
            //}

            LoginInfo loginInfo = new LoginInfo();
            LoginForm login = new LoginForm(loginInfo);
            if (login.ShowDialog() == DialogResult.OK)
            {
                loginLb.Text = loginInfo.Login;
                passwordLb.Text = loginInfo.Password;
            }




        }
    }
}