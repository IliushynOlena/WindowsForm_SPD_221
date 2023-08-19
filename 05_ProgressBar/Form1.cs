namespace _05_ProgressBar
{
    public partial class Form1 : Form
    {
        Timer timer;
        public Form1()
        {
            InitializeComponent();
            progressBar1.Maximum = 50;
            progressBar1.Minimum = 0;
            progressBar1.Step = 1;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 50; i++)
            {
                progressBar1.PerformStep();
                label1.Text = "Value = " + progressBar1.Value.ToString();
                this.Update();
                //Thread.Sleep(50);
            }

        }
    }
}