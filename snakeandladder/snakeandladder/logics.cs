using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Label = System.Windows.Forms.Label;

namespace snakeandladder
{
    internal class logics
    {
        // Roll Dice Method .....
        public static int rolldice(PictureBox px)
        {
            int dice = 0;
            Random random = new Random();
            dice = random.Next(1, 7);
            px.Image = Image.FromFile(@"C:\Users\Administrator\source\repos\snakeandladder\snakeandladder\Resources\" + dice + ".png");
            px.SizeMode = PictureBoxSizeMode.StretchImage;
            return dice;
        }
        public static int move(ref int x,ref int y, PictureBox px , int dice,int p,Label l)
        {
            if(dice + p > 100)
            {
                l.Text = "Can not move";
                l.ForeColor = System.Drawing.Color.Red;
                return 1;
            }
            else
            {

                for (int i = 0; i < dice; i++)
                {


                    if (p == 10)
                    {
                        x = 30;
                        y = 370;
                        p++;
                    }
                    else if (p == 20)
                    {
                        x = 30;
                        y = 325;
                        p++;
                    }
                    else if (p == 30)
                    {
                        x = 30;
                        y = 280;
                        p++;
                    }
                    else if (p == 40)
                    {
                        x = 30;
                        y = 235;
                        p++;
                    }
                    else if (p == 50)
                    {
                        x = 30;
                        y = 195;
                        p++;
                    }
                    else if (p == 60)
                    {
                        x = 30;
                        y = 150;
                        p++;
                    }
                    else if (p == 70)
                    {
                        x = 30;
                        y = 105;
                        p++;
                    }
                    else if (p == 80)
                    {
                        x = 30;
                        y = 60;
                        p++;
                    }
                    else if (p == 90)
                    {
                        x = 30;
                        y = 15;
                        p++;
                    }
                    else
                    {
                        x += 75;
                    }
                    px.Location = new Point(x, y);
                    p++;
                } // loop end
                return p;
            }
            
            
        }// method end

        public static int snake(ref int x, ref int y, int p, PictureBox px)
        {
            if(p == 25)
            {
                x = 330;
                y = 415;
                p = 5;
            }
            else if (p == 34)
            {
                x = 30;
                y = 415;
                p = 1;
            }
            else if (p == 47)
            {
                x = 630;
                y = 370;
                p = 19;
            }
            else if (p == 65)
            {
                x = 105;
                y = 195;
                p = 52;
            }
            else if (p == 87)
            {
                x = 480;
                y = 195;
                p = 57;
            }
            else if (p == 91)
            {
                x = 30;
                y = 150;
                p = 61;
            }
            else if (p == 99)
            {
                x = 630;
                y = 150;
                p = 69;
            }
            px.Location = new Point(x, y);
            return p;
        }
        public static int ladder(ref int x, ref int y, int p, PictureBox px)
        {
            if (p == 3)
            {
                x = 30;
                y = 195;
                p = 51;
            }
            else if (p == 6)
            {
                x = 480;
                y = 325;
                p = 27;
            }
            else if (p == 20)
            {
                x = 705;
                y = 150;
                p = 70;
            }
            else if (p == 36)
            {
                x = 330;
                y = 195;
                p = 55;
            }
            else if (p == 63)
            {
                x = 330;
                y = 15;
                p = 95;
            }
            else if (p == 68)
            {
                x = 555;
                y = 15;
                p = 98;
            }
            px.Location = new Point(x, y);
            return p;
        }
    }
}
