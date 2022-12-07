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
        public float cx = 1.0f;
        public float cy = 1.0f;
        public float w = 1.0f;
        public float h = 1.0f;
        public float l = 1.0f;
        public float anglefi = 1.0f;
        public float angleteta = 1.0f;
        public float angle = 1.0f;
        public triplet startingpoint = new triplet(0.0f, 0.0f, 0.0f);
        public float ctrad = (float)(180 / Math.PI);

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
        public void setAngleRelativeToWorldAngle(float pa) {
            this.angle = angle+pa;
        }

        public void draw(ref Graphics pg)
        {
            cx = (float)Math.Cos(( w+angle) / ctrad) * w + startingpoint.a;
            cy = (float)Math.Sin(( h+angle) / ctrad) * h + startingpoint.b;

            //quare1
            pg.DrawLine(new Pen(Color.Black, 1), startingpoint.a + cx + anglefi, startingpoint.b + cy + anglefi, startingpoint.a + w + cx + anglefi, startingpoint.b + cy + anglefi);
            pg.DrawLine(new Pen(Color.Black, 1), startingpoint.a+ w + cx + anglefi, startingpoint.b + cy + anglefi, startingpoint.a + w + cx + anglefi, startingpoint.b+h + cy + anglefi);
            pg.DrawLine(new Pen(Color.Black, 1), startingpoint.a+ w + cx + anglefi, startingpoint.b+h + cy + anglefi, startingpoint.a + cx + anglefi, startingpoint.b+h + cy + anglefi);
            pg.DrawLine(new Pen(Color.Black, 1), startingpoint.a + cx + anglefi, startingpoint.b+h + cy + anglefi, startingpoint.a + cx + anglefi, startingpoint.b + cy + anglefi);
            //quare2
            pg.DrawLine(new Pen(Color.Black, 1), startingpoint.a+ l + cx + anglefi, startingpoint.b+l + cy + anglefi, startingpoint.a + w+l + cx + anglefi, startingpoint.b+l + cy + anglefi);
            pg.DrawLine(new Pen(Color.Black, 1), startingpoint.a + w + l + cx + anglefi, startingpoint.b + l + cy + anglefi, startingpoint.a + w + l + cx + anglefi, startingpoint.b + h + l + cy + anglefi);
            pg.DrawLine(new Pen(Color.Black, 1), startingpoint.a + w + l + cx + anglefi, startingpoint.b + h + l + cy + anglefi, startingpoint.a + l + cx + anglefi, startingpoint.b + h + l + cy + anglefi);
            pg.DrawLine(new Pen(Color.Black, 1), startingpoint.a + l + cx + anglefi, startingpoint.b + h + l + cy + anglefi, startingpoint.a + l + cx + anglefi, startingpoint.b + l + cy + anglefi);

            //linii de inaltime
            pg.DrawLine(new Pen(Color.Black, 1), startingpoint.a + cx + anglefi, startingpoint.b + cy + anglefi, startingpoint.a + l + cx + anglefi, startingpoint.b + l +cy + anglefi);
            pg.DrawLine(new Pen(Color.Black, 1), startingpoint.a + w + cx + anglefi, startingpoint.b + cy + anglefi, startingpoint.a + w + l + cx + anglefi, startingpoint.b + l + cy + anglefi);
            pg.DrawLine(new Pen(Color.Black, 1), startingpoint.a + w + cx + anglefi, startingpoint.b + h + cy + anglefi, startingpoint.a + w + l + cx + anglefi, startingpoint.b + h + l + cy + anglefi);
            pg.DrawLine(new Pen(Color.Black, 1), startingpoint.a + cx + anglefi, startingpoint.b + h + cy + anglefi, startingpoint.a + l + cx + anglefi, startingpoint.b + h + l + cy + anglefi);


            //             nu uita de teta , unghi si fi unghiruile si unghiul world

        }
    }
}
