using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace snakeandladder
{
    public partial class Form1 : Form
    {
        int flag = 0;  // player 2 turn
        int second = 0;
        bool red = false, blue = false;
        int x = 30, y= 415, diceValue, p=0;
        int bx = 30, by= 415, q=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                button2.Enabled = false;
            }
            pictureBox3.Visible = false;
            pictureBox6.Visible = false;
            pictureBox2.Image = Image.FromFile(@"C:\Users\Administrator\source\repos\snakeandladder\snakeandladder\Resources\OIP.jpg");
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            diceValue = logics.rolldice(pictureBox1);
            label4.Text = diceValue.ToString();
            
            if (red == true)
            {
                p = logics.move(ref x, ref y, pictureBox3,  diceValue, p, label9);
            }
            if (label4.Text == "6" && red == false)
            {
                pictureBox3.Visible = true;
                pictureBox4.Visible = false;
                red = true;
                pictureBox3.Location = new Point(x, y);
                p++;
            }
            if(p == 100)
            {
                MessageBox.Show("You Win .... !");
                button1.Enabled = false;
            }
            p = logics.snake(ref x, ref y, p, pictureBox3);
            p = logics.ladder(ref x, ref y, p, pictureBox3);

            label8.Text = p.ToString();

            if (diceValue == 6)
            {
                flag = 0;
            }
            else
            {
                flag = 1;
                button1.Enabled = false;
                button2.Enabled = true;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            diceValue = logics.rolldice(pictureBox1);
            label11.Text = diceValue.ToString();
            if (blue == true)
            {
                q = logics.move(ref bx, ref by, pictureBox6, diceValue, q, label9);
            }
            if (label11.Text == "6" && blue == false)
            {
                pictureBox6.Visible = true;
                pictureBox5.Visible = false;
                blue = true;
                pictureBox6.Location = new Point(x, y);
                q++;
            }
            if (q == 100)
            {
                MessageBox.Show("You Win .... !");
                button2.Enabled = false;
            }
            q = logics.snake(ref bx, ref by, q, pictureBox6);
            q = logics.ladder(ref bx, ref by, q, pictureBox6);

            if (diceValue == 6)
            {
                flag = 1;
            }
            else
            {
                flag = 0;
                button2.Enabled = false;
                button1.Enabled = true;
            }
        }


    }
}
