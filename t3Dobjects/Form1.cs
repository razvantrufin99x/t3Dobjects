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

        private void button2_Click(object sender, EventArgs e)
        {
            world1.g.Clear(this.BackColor);

            world1.objlist[0].angle += 5;
            world1.objlist[1].angle += 5;
            world1.objlist[2].angle += 5;
            world1.objlist[3].angle += 5;
            world1.objlist[4].angle += 5;
            world1.objlist[5].angle += 5;

            
            world1.objlist[0].draw(ref this.g);
            
            world1.objlist[1].draw(ref this.g);
            
            world1.objlist[2].draw(ref this.g);
            
            world1.objlist[3].draw(ref this.g);
            
            world1.objlist[4].draw(ref this.g);
            
            world1.objlist[5].draw(ref this.g);



        }

        private void button3_Click(object sender, EventArgs e)
        {
            world1.g.Clear(this.BackColor);

            world1.objlist[0].angle += 5;
            world1.objlist[1].angle += 5;
            world1.objlist[2].angle += 5;
            world1.objlist[3].angle += 5;
            world1.objlist[4].angle += 5;
            world1.objlist[5].angle += 5;

            
            world1.objlist[0].draw(ref this.g);
           
            world1.objlist[1].draw(ref this.g);
            
            world1.objlist[2].draw(ref this.g);
            
            world1.objlist[3].draw(ref this.g);
            
            world1.objlist[4].draw(ref this.g);
            
            world1.objlist[5].draw(ref this.g);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            world1.g.Clear(this.BackColor);

            world1.objlist[0].angle += 15;
            world1.objlist[1].angle += 15;
            world1.objlist[2].angle += 15;
            world1.objlist[3].angle += 15;
            world1.objlist[4].angle += 15;
            world1.objlist[5].angle += 15;

           
            world1.objlist[0].draw(ref this.g);
            
            world1.objlist[1].draw(ref this.g);
           
            world1.objlist[2].draw(ref this.g);
           
            world1.objlist[3].draw(ref this.g);
            
            world1.objlist[4].draw(ref this.g);
            
            world1.objlist[5].draw(ref this.g);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            world1.g.Clear(this.BackColor);

            world1.objlist[0].angle += 35;
            world1.objlist[1].angle += 35;
            world1.objlist[2].angle += 35;
            world1.objlist[3].angle += 35;
            world1.objlist[4].angle += 35;
            world1.objlist[5].angle += 35;

          
            world1.objlist[0].draw(ref this.g);
            
            world1.objlist[1].draw(ref this.g);
            
            world1.objlist[2].draw(ref this.g);
           
            world1.objlist[3].draw(ref this.g);
            
            world1.objlist[4].draw(ref this.g);
          
            world1.objlist[5].draw(ref this.g);
        }

        public void clearAndRefresh()
        {
            world1.g.Clear(this.BackColor);
            //1 to x
           
            world1.objlist[0].draw(ref this.g);
            
            world1.objlist[1].draw(ref this.g);
            
            world1.objlist[2].draw(ref this.g);
            
            world1.objlist[3].draw(ref this.g);
            
            world1.objlist[4].draw(ref this.g);
            
            world1.objlist[5].draw(ref this.g);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            world1.angle += 5;
            world1.objlist[0].setAngleRelativeToWorldAngle(5);
            world1.objlist[1].setAngleRelativeToWorldAngle(5);
            world1.objlist[2].setAngleRelativeToWorldAngle(5);
            world1.objlist[3].setAngleRelativeToWorldAngle(5);
            world1.objlist[4].setAngleRelativeToWorldAngle(5);
            world1.objlist[5].setAngleRelativeToWorldAngle(5);
            clearAndRefresh();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            world1.angle -= 5;
          
            world1.objlist[0].setAngleRelativeToWorldAngle(-5);
            world1.objlist[1].setAngleRelativeToWorldAngle(-5);
            world1.objlist[2].setAngleRelativeToWorldAngle(-5);
            world1.objlist[3].setAngleRelativeToWorldAngle(-5);
            world1.objlist[4].setAngleRelativeToWorldAngle(-5);
            world1.objlist[5].setAngleRelativeToWorldAngle(-5);
            clearAndRefresh();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            world1.angle -= 5;

            world1.objlist[0].anglefi += 10;
            world1.objlist[1].anglefi += 10;
            world1.objlist[2].anglefi += 10;
            world1.objlist[3].anglefi += 10;
            world1.objlist[4].anglefi += 10;
            world1.objlist[5].anglefi += 10;
            clearAndRefresh();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            world1.angle -= 5;

            world1.objlist[0].anglefi -= 10;
            world1.objlist[1].anglefi -= 10;
            world1.objlist[2].anglefi -= 10;
            world1.objlist[3].anglefi -= 10;
            world1.objlist[4].anglefi -= 10;
            world1.objlist[5].anglefi -= 10;
            clearAndRefresh();
        }
    }
}
