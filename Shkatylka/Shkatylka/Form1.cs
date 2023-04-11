using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shkatylka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
        }

        Graphics g;
        Componov cp;
        Comp cur;

        private void button5_Click(object sender, EventArgs e)
        {
            button6.Enabled = true;
            button7.Enabled = true;

            cp = new Componov(150,10);
            g.DrawImage(cp.pic, new Rectangle(cp.x, cp.y, cp.h, cp.w));

            button5.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            cp.remove(cur);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            g.FillRectangle(new SolidBrush(Color.LightGray), new Rectangle(cp.x, cp.y, cp.h, cp.w));
            cp.move(4);
            g.DrawImage(cp.pic, new Rectangle(cp.x, cp.y, cp.h, cp.w));
            for (int i = 0; i < cp.masc.Count; i++)
            {
                g.DrawImage(cp.masc[i].pic, new Rectangle(cp.masc[i].x, cp.masc[i].y, cp.masc[i].h, cp.masc[i].w));
            }
        }
        Random r = new Random();
        private void button6_Click(object sender, EventArgs e)
        {
            dragoz1 d1 = new dragoz1(r.Next(cp.x + 100, cp.h-10), r.Next(cp.y + 100, cp.w - 50));
            cp.add(d1);

            g.DrawImage(d1.pic, new Rectangle(d1.x, d1.y, d1.h, d1.w));
        }

        private void button7_Click(object sender, EventArgs e)
        {
            dragoz2 d2 = new dragoz2(r.Next(cp.x + 100, cp.h - 10), r.Next(cp.y + 100, cp.w - 50));
            cp.add(d2);

            g.DrawImage(d2.pic, new Rectangle(d2.x, d2.y, d2.h, d2.w));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            g.FillRectangle(new SolidBrush(Color.LightGray), new Rectangle(cp.x, cp.y, cp.h, cp.w));
            cp.move(2);
            g.DrawImage(cp.pic, new Rectangle(cp.x, cp.y, cp.h, cp.w));
            for (int i = 0; i < cp.masc.Count; i++)
            {
                g.DrawImage(cp.masc[i].pic, new Rectangle(cp.masc[i].x, cp.masc[i].y, cp.masc[i].h, cp.masc[i].w));
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            g.FillRectangle(new SolidBrush(Color.LightGray), new Rectangle(cp.x, cp.y, cp.h, cp.w));
            cp.move(3);
            g.DrawImage(cp.pic, new Rectangle(cp.x, cp.y, cp.h, cp.w));
            for (int i = 0; i < cp.masc.Count; i++)
            {
                g.DrawImage(cp.masc[i].pic, new Rectangle(cp.masc[i].x, cp.masc[i].y, cp.masc[i].h, cp.masc[i].w));
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            g.FillRectangle(new SolidBrush(Color.LightGray), new Rectangle(cp.x, cp.y, cp.h, cp.w));
            cp.move(1);
            g.DrawImage(cp.pic, new Rectangle(cp.x, cp.y, cp.h, cp.w));
            for (int i = 0; i < cp.masc.Count; i++)
            {
                g.DrawImage(cp.masc[i].pic, new Rectangle(cp.masc[i].x, cp.masc[i].y, cp.masc[i].h, cp.masc[i].w));
            }
        }
    }
}
