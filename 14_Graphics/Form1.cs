using System.Drawing;

namespace _14_Graphics
{
    public partial class Form1 : Form
    {
        int redraw_count = 0;
        List<Point> points = new List<Point>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            using (Graphics g = this.CreateGraphics())
            {
                Pen pen = new Pen(Color.Blue, 20);
                pen.StartCap = System.Drawing.Drawing2D.LineCap.DiamondAnchor;
                pen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
                pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                pen.DashCap = System.Drawing.Drawing2D.DashCap.Round;
                g.DrawLine(pen, 20, 200, 470, 200);
            }//Dispose()

            /*
           

            int x = 63;
            int y = 73;
            int height = 240;
            int width = 240;
            Pen pen = new Pen(Brushes.Aqua, 6);
          

            Point point = new Point(10, 10);
            Size size = new Size(640, 640);
            
            Rectangle rect1 = new Rectangle(point, size);
            Rectangle rect2 = new Rectangle(x,y,height,width);

            g.FillEllipse(Brushes.Yellow, rect1);
            g.DrawEllipse(pen, rect2); 
            */
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            using (Graphics g = this.CreateGraphics())
            {
                Pen pen = new Pen(Color.Blue, 20);
                pen.StartCap = System.Drawing.Drawing2D.LineCap.DiamondAnchor;
                pen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
                pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                pen.DashCap = System.Drawing.Drawing2D.DashCap.Flat;
                g.DrawLine(pen, 20, 700, 470, 700);


                int x = 63;
                int y = 73;
                int height = 240;
                int width = 240;
                Pen pen2 = new Pen(Brushes.Aqua, 6);
                pen2.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;


                Point point = new Point(10, 10);
                Size size = new Size(640, 640);

                Rectangle rect1 = new Rectangle(point, size);
                Rectangle rect2 = new Rectangle(x, y, height, width);

                g.FillEllipse(Brushes.Yellow, rect1);
                g.DrawEllipse(pen2, rect2);

            }//Dispose()



        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            PrintPoints(e.Graphics, e.ClipRectangle);
            /*
            this.Text = $"{redraw_count++}";
            // Graphics g = this.CreateGraphics();
            Graphics g = e.Graphics;

            int x = 63;
            int y = 73;
            int height = 240;
            int width = 240;
            Pen pen = new Pen(Brushes.Aqua, 6);


            Point point = new Point(10, 10);
            Size size = new Size(640, 640);

            Rectangle rect1 = new Rectangle(point, size);
            Rectangle rect2 = new Rectangle(x, y, height, width);

            g.FillEllipse(Brushes.Yellow, rect1);
            g.DrawEllipse(pen, rect2);
            */

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Point point = e.Location;
            points.Add(point);

            this.CreateGraphics().FillEllipse(Brushes.Teal, point.X-10, point.Y-10, 20, 20);
        }
        private void PrintPoints(Graphics g, Rectangle area)
        {
            foreach (Point p in points)
            {
                g.FillEllipse(Brushes.Teal, p.X - 10, p.Y - 10, 20, 20);
            }
        }
    }
}