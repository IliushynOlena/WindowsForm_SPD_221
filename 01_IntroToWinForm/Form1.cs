namespace _01_IntroToWinForm
{
    public partial class Form1 : Form
    {
        Random random = new Random();   
        Point startLocation;
        public Form1()
        {
            InitializeComponent();
            startLocation = CSharpBtn.Location;
        }

      
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            EnterBtn.BackColor = Color.Cyan;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            EnterBtn.BackColor = Color.Lime;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello WF","Congratulation!!!!",MessageBoxButtons.OK,
                MessageBoxIcon.Asterisk);
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to close window?", "Ask window",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            { this.Close(); }
        }

        private void LeftBtn_Click(object sender, EventArgs e)
        {
            CSharpBtn.Location = new Point( CSharpBtn.Location.X-4, CSharpBtn.Location.Y );
        }

        private void RightBtn_Click(object sender, EventArgs e)
        {
            CSharpBtn.Location = new Point(CSharpBtn.Location.X + 4, CSharpBtn.Location.Y);

        }
        private void CSharpBtn_Click(object sender, EventArgs e)
        {
            CSharpBtn.Location = startLocation;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = $"Mouse position : {e.X} : {e.Y} ";
            Point mouse = e.Location;
            if (mouse.X >= CSharpBtn.Left - 20 && mouse.X <= CSharpBtn.Left + CSharpBtn.Width + 20)
            {
                if (mouse.X >= CSharpBtn.Left)
                    CSharpBtn.Left = CSharpBtn.Left - 5;
                else
                    CSharpBtn.Left = CSharpBtn.Left + 5;
            }

            if(CSharpBtn.Left < 0)
            {
                CSharpBtn.Location = new Point(random.Next(this.Width),random.Next(this.Height));
            }
            if(CSharpBtn.Right > this.Width-30)
            {
                CSharpBtn.Location = new Point(random.Next(this.Width),random.Next(this.Height));

            }

          


        }
    }
}