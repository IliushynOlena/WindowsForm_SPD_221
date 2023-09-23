namespace _17_PictureBox
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
            pictureBox1.ImageLocation = @"https://loremflickr.com/500/500";
            //foreach (var item in this.Controls.OfType<PictureBox>())
            //{
            //  //item.ImageLocation = @"https://loremflickr.com/400/400";
            //  item.ImageLocation = @"https://loremflickr.com/320/240";

            //}
            timer.Interval = 3000;
            timer.Tick += Timer_Tick; ;
            timer.Start();

        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            PictureBox pictureBox = new PictureBox()
            {
                Location = new Point(random.Next(0,this.Width), 0),
                SizeMode = PictureBoxSizeMode.Zoom,
                Width = 200,
                Height = 200,
                ImageLocation = @"https://loremflickr.com/400/400"
            };
            //timer.Stop();
            this.Controls.Add(pictureBox);
        }

        private bool IsOutsideLeftBorder(Point coord)
        {
            return coord.X < 0;
        }
        private bool IsOutsideRightBorder(Point coord)
        {
            return coord.X + pictureBox1.Width > this.Width;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int x = pictureBox1.Location.X;
            int y = pictureBox1.Location.Y;


            switch (e.KeyCode)
            {
                case Keys.Left:
                    if (!IsOutsideLeftBorder(new Point(x - 5, y)))
                        x -= 5;
                    else x = 0;
                    break;
                case Keys.Up:
                    y -= 5;
                    break;
                case Keys.Right:
                    if (!IsOutsideRightBorder(new Point(x + 5, y)))
                        x += 5;
                    else
                        x = this.Width - pictureBox1.Width - 200;
                    break;
                case Keys.Down:
                    y += 5;
                    break;
            }
            pictureBox1.Location = new Point(x, y);


        }
    }
}