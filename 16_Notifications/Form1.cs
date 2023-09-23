namespace _16_Notifications
{
    public partial class Form1 : Form
    {
        int count = 0;
        public Form1()
        {
            InitializeComponent();
            timer.Tick += Timer1_Tick;
            timer.Interval = 1000;

            this.ShowInTaskbar = false;
            notifyIcon.Click += NotifyIcon_Click;
        }

        private void NotifyIcon_Click(object? sender, EventArgs e)
        {
            this.ShowInTaskbar = true;
            this.WindowState = FormWindowState.Maximized;
        }

        private void Timer1_Tick(object? sender, EventArgs e)
        {
            timerLb.Text = (++count).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer.Start();
            StartBtn.Enabled = false;
            StopBtn.Enabled = true;

            notifyIcon.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon.BalloonTipText = "Таймер почав відлік!!!";
            notifyIcon.BalloonTipTitle = "Увага!!!";
            notifyIcon.ShowBalloonTip(5);
            //notifyIcon.ShowBalloonTip(5, "Error", "Bla bla text", ToolTipIcon.Error); ;
        }

        private void StopBtn_Click(object sender, EventArgs e)
        {
            timer.Stop();
            StopBtn.Enabled = false;
            StartBtn.Enabled = true;

            notifyIcon.BalloonTipIcon = ToolTipIcon.Warning;
            notifyIcon.BalloonTipText = "Таймер зупинився!!!";
            notifyIcon.BalloonTipTitle = "Увага!!!";
            notifyIcon.ShowBalloonTip(3);


        }
    }
}