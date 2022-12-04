using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t3Dobjects
{
    public class calc3dl
    {

        public Graphics g;
        public Pen pen0 = new Pen(Color.Black);
        public float cx, cy, px, py;
        public float step = (360 / 32);
        public float ctrad = (float)(180 / Math.PI);
        public float dimx, dimy, posx, posy;
        public int mx, my;
        public int rotatx = 2;
        public int rotaty = 2;


        public void drawacircle1()
        {


            for (float i = 0; i < 360 + step; i += step)
            {
                px = cx;
                py = cy;

                cx = (float)Math.Cos((i + mx) / ctrad) * dimx + posx;
                cy = (float)Math.Sin((i + my) / ctrad) * dimy + posy;

                g.DrawLine(pen0, cx, cy, px, py);
            }
        }
    }
}
