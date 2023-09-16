using System.Drawing;

namespace _15_Paint
{
    public partial class Form1 : Form
    {
        enum ShapyTypes { Rectangle, Line, Ellipse};
        Point startLocation;
        List<MyShape> shapes = new List<MyShape>();
        public Form1()
        {
            InitializeComponent();
            colorCb.Items.Add(Color.Red);
            colorCb.Items.Add(Color.Green);
            colorCb.Items.Add(Color.Yellow);
            colorCb.Items.Add(Color.Blue);
            colorCb.SelectedIndex = 0;
            //this.CreateGraphics().FillRectangle()

            foreach (var item in Enum.GetValues(typeof(ShapyTypes)))
            {
                typeList.Items.Add(item);
            }
            typeList.SelectedIndex = 0;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            this.Text = "Down" + e.Location;
            startLocation = e.Location;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            Point endLocation = e.Location;
            this.Text = "Up" + e.Location;
            Color color = (Color)colorCb.SelectedItem;
            SolidBrush brush = new SolidBrush(color);
            Graphics g = this.CreateGraphics();
            MyShape shape = null;
            var type = (ShapyTypes)typeList.SelectedItem;

            if(type == ShapyTypes.Rectangle || type == ShapyTypes.Ellipse)
            {
                Rectangle rectangle = new Rectangle();

                rectangle.X = startLocation.X < endLocation.X ? startLocation.X : endLocation.X;
                rectangle.Y = startLocation.Y < endLocation.Y ? startLocation.Y : endLocation.Y;

                rectangle.Width = Math.Abs(e.X - startLocation.X);
                rectangle.Height = Math.Abs(e.Y - startLocation.Y);

                //SolidBrush brush = new SolidBrush((Color)colorCb.SelectedItem);
                if(type == ShapyTypes.Rectangle)
                    shape = new MyRectangle(rectangle, color);
                else
                    shape = new MyEllipse(rectangle, color);              

            }
            else if(type == ShapyTypes.Line)
            {
                 shape = new MyLine(color,startLocation, endLocation);         
            }

            shape.Draw(g);
            shapes.Add(shape);










        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            foreach (var s in shapes)
            {

                s.Draw(g);
            }
        }
    }
}