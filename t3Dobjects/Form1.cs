using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace t3Dobjects
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Graphics g;
        public world world1 = new world();

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 800;
            this.Height = 600;

            g = CreateGraphics();

            world1 = new world(ref this.g, 1.0f, 1.0f, 1.0f, 800, 600, 600);

           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            world1.objlist.Add(new objt3d(10, 10, 10, 10, 1043, 10));
            world1.objlist[0].draw(ref this.g);
            world1.objlist.Add(new objt3d(10, 10, 102, 101, 10, 101));
            world1.objlist[1].draw(ref this.g);
            world1.objlist.Add(new objt3d(10, 10, 101, 10, 101, 10));
            world1.objlist[2].draw(ref this.g);
            world1.objlist.Add(new objt3d(10, 101, 10, 10, 10, 10));
            world1.objlist[3].draw(ref this.g);
            world1.objlist.Add(new objt3d(10, 102, 10, 101, 101, 10));
            world1.objlist[4].draw(ref this.g);
            world1.objlist.Add(new objt3d(10, 101, 103, 10, 101, 10));
            world1.objlist[5].draw(ref this.g);
        }
    }
}
