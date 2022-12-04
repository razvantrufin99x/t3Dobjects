using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t3Dobjects
{
    public class world
    {
        public Graphics g = null;
        public float anglefi = 1.0f;
        public float angleteta = 1.0f;
        public float angle = 1.0f;

        public List<objt3d> objlist = new List<objt3d>();
        public float w;
        public float h;
        public float l;
        public world() { }
        public world(ref Graphics pg, float pangle, float panglefi, float pangleteta, float pw, float ph, float pl) {
            this.w = pw;
            this.h = ph;
            this.l = pl;
            this.anglefi = panglefi;
            this.angleteta = pangleteta;
            this.angle = pangle;
            g = pg;
        }
       
    }
}
