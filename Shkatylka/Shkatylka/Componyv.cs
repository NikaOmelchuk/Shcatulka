using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shkatylka
{
    public abstract class Comp
    {
        public int x, y, h, w;
        public Bitmap pic;
        public abstract void move(int n);
    }

    public class dragoz1 : Comp
    {
        public dragoz1(int x, int y)
        {
            this.x = x;
            this.y = y;
            h = 50; w = 50;
            pic = new Bitmap(@"C:\Users\Саша\Desktop\Визуалка\лаби арітектура\Келементи\д1.png");
        }

        public override void move(int n)
        {
            switch(n)
            {
                case 1:
                    x += 5;
                    break;
                case 2:
                    x -= 5;
                    break;
                case 3:
                    y += 5;
                    break;
                case 4:
                    y -= 5;
                    break;
            }
        }
    }


    public class dragoz2 : Comp
    {
        public dragoz2(int x, int y)
        {
            this.x = x;
            this.y = y;
            h = 50; w = 50;
            pic = new Bitmap(@"C:\Users\Саша\Desktop\Визуалка\лаби арітектура\Келементи\д3.png");
        }

        public override void move(int n)
        {
            switch (n)
            {
                case 1:
                    x += 5;
                    break;
                case 2:
                    x -= 5;
                    break;
                case 3:
                    y += 5;
                    break;
                case 4:
                    y -= 5;
                    break;
            }
        }
    }

    public  class Componov: Comp
    {
        public List<Comp> masc = new List<Comp>();

        public Componov(int x, int y)
        {
            this.x = x;
            this.y = y;
            h = 500; w = 400;
            pic = new Bitmap(@"C:\Users\Саша\Desktop\Визуалка\лаби арітектура\Келементи\шкатулка.png");
        }

        public void add(Comp c)
        {
            masc.Add(c);
        }

        public void remove(Comp c)
        {
            masc.Remove(c);
        }

        public override void move(int n)
        {

            switch (n)
            {
                case 1:
                    x += 5;
                    for (int i = 0; i < masc.Count; i++)
                        masc[i].move(1);
                    break;
                case 2:
                    x -= 5;
                    for (int i = 0; i < masc.Count; i++)
                        masc[i].move(2);
                    break;
                case 3:
                    y += 5;
                    for (int i = 0; i < masc.Count; i++)
                        masc[i].move(3);
                    break;
                case 4:
                    y -= 5;
                    for (int i = 0; i < masc.Count; i++)
                        masc[i].move(4);
                    break;
            }
        }
    }
}
