using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Paint
{
    public class MyRectangle : MyShape
    {
        public Rectangle Rectangle { get; set; }
        public Color Color { get; set; }
        public MyRectangle()
        {

        }
        public MyRectangle(Rectangle R, Color C)
        {
            Rectangle = R;
            Color = C;
        }

        public override void Draw(Graphics g)
        {
            g.FillRectangle(new SolidBrush(Color), Rectangle);
        }
    }
}
