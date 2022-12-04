using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t3Dobjects
{
    public  class objt3d
    {
        public float w = 1.0f;
        public float h = 1.0f;
        public float l = 1.0f;
        public float anglefi = 1.0f;
        public float angleteta = 1.0f;
        public float angle = 1.0f;
        public triplet startingpoint = new triplet(0.0f, 0.0f, 0.0f);
        public objt3d() {}
        public objt3d(float pa, float pb, float pc, float pw, float ph, float pl, float pangle, float panglefi, float pangleteta)
        {
            startingpoint.a = pa;
            startingpoint.b = pb;
            startingpoint.c = pc;
            this.w = pw;
            this.h = ph;
            this.l = pl;
            this.anglefi = panglefi;
            this.angleteta = pangleteta;
            this.angle = pangle;

        }
        public objt3d(float pa, float pb, float pc, float pw, float ph, float pl)
        {
            startingpoint.a = pa;
            startingpoint.b = pb;
            startingpoint.c = pc;
            this.w = pw;
            this.h = ph;
            this.l = pl;

        }
        public objt3d(triplet pt, float pw, float ph, float pl)
        {
            startingpoint = pt;
            this.w = pw;
            this.h = ph;
            this.l = pl;
        }
        public objt3d(ref triplet pt, float pw, float ph, float pl)
        {
            startingpoint = pt;
            this.w = pw;
            this.h = ph;
            this.l = pl;

        }
        public void draw(ref Graphics pg)
        {
            //quare1
            pg.DrawLine(new Pen(Color.Black, 1), startingpoint.a, startingpoint.b, startingpoint.a + w, startingpoint.b);
            pg.DrawLine(new Pen(Color.Black, 1), startingpoint.a+w, startingpoint.b, startingpoint.a + w, startingpoint.b+h);
            pg.DrawLine(new Pen(Color.Black, 1), startingpoint.a+w, startingpoint.b+h, startingpoint.a, startingpoint.b+h);
            pg.DrawLine(new Pen(Color.Black, 1), startingpoint.a, startingpoint.b+h, startingpoint.a , startingpoint.b);
            //quare2
            pg.DrawLine(new Pen(Color.Black, 1), startingpoint.a+l, startingpoint.b+l, startingpoint.a + w+l, startingpoint.b+l);
            pg.DrawLine(new Pen(Color.Black, 1), startingpoint.a + w + l, startingpoint.b + l, startingpoint.a + w + l, startingpoint.b + h + l);
            pg.DrawLine(new Pen(Color.Black, 1), startingpoint.a + w + l, startingpoint.b + h + l, startingpoint.a + l, startingpoint.b + h + l);
            pg.DrawLine(new Pen(Color.Black, 1), startingpoint.a + l, startingpoint.b + h + l, startingpoint.a + l, startingpoint.b + l);

            //linii de inaltime
            pg.DrawLine(new Pen(Color.Black, 1), startingpoint.a, startingpoint.b, startingpoint.a + l, startingpoint.b + l);
            pg.DrawLine(new Pen(Color.Black, 1), startingpoint.a + w, startingpoint.b, startingpoint.a + w + l, startingpoint.b + l);
            pg.DrawLine(new Pen(Color.Black, 1), startingpoint.a + w, startingpoint.b + h, startingpoint.a + w + l, startingpoint.b + h + l);
            pg.DrawLine(new Pen(Color.Black, 1), startingpoint.a, startingpoint.b + h, startingpoint.a + l, startingpoint.b + h + l);


            //             nu uita de teta , unghi si fi unghiruile si unghiul world

        }
    }
}
