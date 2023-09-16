using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Paint
{
    public class MyEllipse : MyRectangle
    {
      
        public MyEllipse()
        {

        }
        public MyEllipse(Rectangle R, Color C) : base(R, C) { }
      

        public override void Draw(Graphics g)
        {
            g.FillEllipse(new SolidBrush(Color), Rectangle);
        }
    }
}
