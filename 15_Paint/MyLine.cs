using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Paint
{
    public class MyLine : MyShape
    {
        public Pen Pen { get; set; }
        public Point Start { get; set; }
        public Point End { get; set; }
        public MyLine()
        {

        }
        public MyLine(Color c, Point S, Point E)
        {
            Pen = new Pen(c);
            Start = S;
            End = E;
        }
        public override void Draw(Graphics g)
        {
            g.DrawLine(Pen,Start, End); 
        }
    }
}
