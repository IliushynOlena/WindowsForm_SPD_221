namespace _06_ProgressBar2
{
    public partial class Form1 : Form
    {
        System.Windows.Forms.Timer timer = null;
        public Form1()
        {
            InitializeComponent();
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 100;
            timer.Tick += Timer_Tick;
            UpdateColor();

        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            if (progressBar1.Value == progressBar1.Maximum)
                progressBar1.Value = progressBar1.Minimum;
            else
                progressBar1.Value++;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Value = progressBar1.Minimum;

            decimal max = (numericUpDown1.Value > progressBar1.Maximum ? 
                progressBar1.Maximum : numericUpDown1.Value);

            while (progressBar1.Value < max)
            {
                progressBar1.Value++;
                progressBar1.Update();
                Thread.Sleep(50);
            }
            progressBar1.Style = ProgressBarStyle.Marquee;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            UpdateColor();
            label5.Text = trackBar1.Value.ToString();
            label6.Text = trackBar2.Value.ToString();
            label7.Text = trackBar3.Value.ToString();
        }

        private void UpdateColor()
        {
            Color c = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);
            this.BackColor = c;
        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            this.Opacity = trackBar4.Value / 100.0;
        }

        private void toolStripProgressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}