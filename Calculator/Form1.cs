using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void n1_Click(object sender, EventArgs e)
        {
            if (o1.Text == "")
            {
                o1.Text = "1";
                button1.Image = (Image)(new Bitmap(pictureBox1.Image, new Size(32, 32)));
                button2.Image = (Image)(new Bitmap(pictureBox1.Image, new Size(32, 32)));
                button3.Image = (Image)(new Bitmap(pictureBox1.Image, new Size(32, 32)));
                button4.Image = (Image)(new Bitmap(pictureBox1.Image, new Size(32, 32)));
                button5.Image = (Image)(new Bitmap(pictureBox1.Image, new Size(32, 32)));
                button6.Image = (Image)(new Bitmap(pictureBox1.Image, new Size(32, 32)));
                button7.Image = (Image)(new Bitmap(pictureBox1.Image, new Size(32, 32)));
                button8.Image = (Image)(new Bitmap(pictureBox1.Image, new Size(32, 32)));
                button9.Image = (Image)(new Bitmap(pictureBox1.Image, new Size(32, 32)));
                button10.Image = (Image)(new Bitmap(pictureBox1.Image, new Size(32, 32)));

                button1.Text = "1";
                button2.Text = "1";
                button3.Text = "1";
                button4.Text = "1";
                button5.Text = "1";
                button6.Text = "1";
                button7.Text = "1";
                button8.Text = "1";
                button9.Text = "1";
                button10.Text = "1";

            }
            else
            {
                o2.Text = "1";

                button1.Visible = true;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                button5.Visible = false;
                button6.Visible = false;
                button7.Visible = false;
                button8.Visible = false;
                button9.Visible = false;

            }
        }
        private void n2_Click(object sender, EventArgs e)
        {
            if (o1.Text == "")
            {
                o1.Text = "2";
                button1.Image = (Image)(new Bitmap(pictureBox2.Image, new Size(32, 32)));
                button2.Image = (Image)(new Bitmap(pictureBox2.Image, new Size(32, 32)));
                button3.Image = (Image)(new Bitmap(pictureBox2.Image, new Size(32, 32)));
                button4.Image = (Image)(new Bitmap(pictureBox2.Image, new Size(32, 32)));
                button5.Image = (Image)(new Bitmap(pictureBox2.Image, new Size(32, 32)));
                button6.Image = (Image)(new Bitmap(pictureBox2.Image, new Size(32, 32)));
                button7.Image = (Image)(new Bitmap(pictureBox2.Image, new Size(32, 32)));
                button8.Image = (Image)(new Bitmap(pictureBox2.Image, new Size(32, 32)));
                button9.Image = (Image)(new Bitmap(pictureBox2.Image, new Size(32, 32)));
                button10.Image = (Image)(new Bitmap(pictureBox2.Image, new Size(32, 32)));

                button1.Text = "2";
                button2.Text = "2";
                button3.Text = "2";
                button4.Text = "2";
                button5.Text = "2";
                button6.Text = "2";
                button7.Text = "2";
                button8.Text = "2";
                button9.Text = "2";
                button10.Text = "2";
            }
            else
            {
                o2.Text = "2";
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = false;
                button4.Visible = false;
                button5.Visible = false;
                button6.Visible = false;
                button7.Visible = false;
                button8.Visible = false;
                button9.Visible = false;

            }
        }
        private void n3_Click(object sender, EventArgs e)
        {
            if (o1.Text == "")
            {
                o1.Text = "3";
                button1.Image = (Image)(new Bitmap(pictureBox3.Image, new Size(32, 32)));
                button2.Image = (Image)(new Bitmap(pictureBox3.Image, new Size(32, 32)));
                button3.Image = (Image)(new Bitmap(pictureBox3.Image, new Size(32, 32)));
                button4.Image = (Image)(new Bitmap(pictureBox3.Image, new Size(32, 32)));
                button5.Image = (Image)(new Bitmap(pictureBox3.Image, new Size(32, 32)));
                button6.Image = (Image)(new Bitmap(pictureBox3.Image, new Size(32, 32)));
                button7.Image = (Image)(new Bitmap(pictureBox3.Image, new Size(32, 32)));
                button8.Image = (Image)(new Bitmap(pictureBox3.Image, new Size(32, 32)));
                button9.Image = (Image)(new Bitmap(pictureBox3.Image, new Size(32, 32)));
                button10.Image = (Image)(new Bitmap(pictureBox3.Image, new Size(32, 32)));

                button1.Text = "3";
                button2.Text = "3";
                button3.Text = "3";
                button4.Text = "3";
                button5.Text = "3";
                button6.Text = "3";
                button7.Text = "3";
                button8.Text = "3";
                button9.Text = "3";
                button10.Text = "3";
            }
            else
            {
                o2.Text = "3";
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = false;
                button5.Visible = false;
                button6.Visible = false;
                button7.Visible = false;
                button8.Visible = false;
                button9.Visible = false;

            }
        }
        private void n4_Click(object sender, EventArgs e)
        {
            if (o1.Text == "")
            {
                o1.Text = "4";
                button1.Image = (Image)(new Bitmap(pictureBox4.Image, new Size(32, 32)));
                button2.Image = (Image)(new Bitmap(pictureBox4.Image, new Size(32, 32)));
                button3.Image = (Image)(new Bitmap(pictureBox4.Image, new Size(32, 32)));
                button4.Image = (Image)(new Bitmap(pictureBox4.Image, new Size(32, 32)));
                button5.Image = (Image)(new Bitmap(pictureBox4.Image, new Size(32, 32)));
                button6.Image = (Image)(new Bitmap(pictureBox4.Image, new Size(32, 32)));
                button7.Image = (Image)(new Bitmap(pictureBox4.Image, new Size(32, 32)));
                button8.Image = (Image)(new Bitmap(pictureBox4.Image, new Size(32, 32)));
                button9.Image = (Image)(new Bitmap(pictureBox4.Image, new Size(32, 32)));
                button10.Image = (Image)(new Bitmap(pictureBox4.Image, new Size(32, 32)));

                button1.Text = "4";
                button2.Text = "4";
                button3.Text = "4";
                button4.Text = "4";
                button5.Text = "4";
                button6.Text = "4";
                button7.Text = "4";
                button8.Text = "4";
                button9.Text = "4";
                button10.Text = "4";
            }
            else
            {
                o2.Text = "4";
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                button5.Visible = false;
                button6.Visible = false;
                button7.Visible = false;
                button8.Visible = false;
                button9.Visible = false;

            }
        }
        private void n5_Click(object sender, EventArgs e)
        {
            if (o1.Text == "")
            {
                o1.Text = "5";
                button1.Image = (Image)(new Bitmap(pictureBox5.Image, new Size(32, 32)));
                button2.Image = (Image)(new Bitmap(pictureBox5.Image, new Size(32, 32)));
                button3.Image = (Image)(new Bitmap(pictureBox5.Image, new Size(32, 32)));
                button4.Image = (Image)(new Bitmap(pictureBox5.Image, new Size(32, 32)));
                button5.Image = (Image)(new Bitmap(pictureBox5.Image, new Size(32, 32)));
                button6.Image = (Image)(new Bitmap(pictureBox5.Image, new Size(32, 32)));
                button7.Image = (Image)(new Bitmap(pictureBox5.Image, new Size(32, 32)));
                button8.Image = (Image)(new Bitmap(pictureBox5.Image, new Size(32, 32)));
                button9.Image = (Image)(new Bitmap(pictureBox5.Image, new Size(32, 32)));
                button10.Image = (Image)(new Bitmap(pictureBox5.Image, new Size(32, 32)));

                button1.Text = "5";
                button2.Text = "5";
                button3.Text = "5";
                button4.Text = "5";
                button5.Text = "5";
                button6.Text = "5";
                button7.Text = "5";
                button8.Text = "5";
                button9.Text = "5";
                button10.Text = "5";
            }
            else
            {
                o2.Text = "5";
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                button5.Visible = true;
                button6.Visible = false;
                button7.Visible = false;
                button8.Visible = false;
                button9.Visible = false;

            }
        }
        private void n6_Click(object sender, EventArgs e)
        {
            if (o1.Text == "")
            {
                o1.Text = "6";
                button1.Image = (Image)(new Bitmap(pictureBox6.Image, new Size(32, 32)));
                button2.Image = (Image)(new Bitmap(pictureBox6.Image, new Size(32, 32)));
                button3.Image = (Image)(new Bitmap(pictureBox6.Image, new Size(32, 32)));
                button4.Image = (Image)(new Bitmap(pictureBox6.Image, new Size(32, 32)));
                button5.Image = (Image)(new Bitmap(pictureBox6.Image, new Size(32, 32)));
                button6.Image = (Image)(new Bitmap(pictureBox6.Image, new Size(32, 32)));
                button7.Image = (Image)(new Bitmap(pictureBox6.Image, new Size(32, 32)));
                button8.Image = (Image)(new Bitmap(pictureBox6.Image, new Size(32, 32)));
                button9.Image = (Image)(new Bitmap(pictureBox6.Image, new Size(32, 32)));
                button10.Image = (Image)(new Bitmap(pictureBox6.Image, new Size(32, 32)));

                button1.Text = "6";
                button2.Text = "6";
                button3.Text = "6";
                button4.Text = "6";
                button5.Text = "6";
                button6.Text = "6";
                button7.Text = "6";
                button8.Text = "6";
                button9.Text = "6";
                button10.Text = "6";
            }
            else
            {
                o2.Text = "6";
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                button5.Visible = true;
                button6.Visible = true;
                button7.Visible = false;
                button8.Visible = false;
                button9.Visible = false;

            }
        }
        private void n7_Click(object sender, EventArgs e)
        {
            if (o1.Text == "")
            {
                o1.Text = "7";
                button1.Image = (Image)(new Bitmap(pictureBox7.Image, new Size(32, 32)));
                button2.Image = (Image)(new Bitmap(pictureBox7.Image, new Size(32, 32)));
                button3.Image = (Image)(new Bitmap(pictureBox7.Image, new Size(32, 32)));
                button4.Image = (Image)(new Bitmap(pictureBox7.Image, new Size(32, 32)));
                button5.Image = (Image)(new Bitmap(pictureBox7.Image, new Size(32, 32)));
                button6.Image = (Image)(new Bitmap(pictureBox7.Image, new Size(32, 32)));
                button7.Image = (Image)(new Bitmap(pictureBox7.Image, new Size(32, 32)));
                button8.Image = (Image)(new Bitmap(pictureBox7.Image, new Size(32, 32)));
                button9.Image = (Image)(new Bitmap(pictureBox7.Image, new Size(32, 32)));
                button10.Image = (Image)(new Bitmap(pictureBox7.Image, new Size(32, 32)));

                button1.Text = "7";
                button2.Text = "7";
                button3.Text = "7";
                button4.Text = "7";
                button5.Text = "7";
                button6.Text = "7";
                button7.Text = "7";
                button8.Text = "7";
                button9.Text = "7";
                button10.Text = "7";
            }
            else
            {
                o2.Text = "7";
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                button5.Visible = true;
                button6.Visible = true;
                button7.Visible = true;
                button8.Visible = false;
                button9.Visible = false;

            }
        }
        private void n8_Click(object sender, EventArgs e)
        {
            if (o1.Text == "")
            {
                o1.Text = "8";
                button1.Image = (Image)(new Bitmap(pictureBox8.Image, new Size(32, 32)));
                button2.Image = (Image)(new Bitmap(pictureBox8.Image, new Size(32, 32)));
                button3.Image = (Image)(new Bitmap(pictureBox8.Image, new Size(32, 32)));
                button4.Image = (Image)(new Bitmap(pictureBox8.Image, new Size(32, 32)));
                button5.Image = (Image)(new Bitmap(pictureBox8.Image, new Size(32, 32)));
                button6.Image = (Image)(new Bitmap(pictureBox8.Image, new Size(32, 32)));
                button7.Image = (Image)(new Bitmap(pictureBox8.Image, new Size(32, 32)));
                button8.Image = (Image)(new Bitmap(pictureBox8.Image, new Size(32, 32)));
                button9.Image = (Image)(new Bitmap(pictureBox8.Image, new Size(32, 32)));
                button10.Image = (Image)(new Bitmap(pictureBox8.Image, new Size(32, 32)));

                button1.Text = "8";
                button2.Text = "8";
                button3.Text = "8";
                button4.Text = "8";
                button5.Text = "8";
                button6.Text = "8";
                button7.Text = "8";
                button8.Text = "8";
                button9.Text = "8";
                button10.Text = "8";
            }
            else
            {
                o2.Text = "8";
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                button5.Visible = true;
                button6.Visible = true;
                button7.Visible = true;
                button8.Visible = true;
                button9.Visible = false;

            }
        }
        private void n9_Click(object sender, EventArgs e)
        {
            if (o1.Text == "")
            {
                o1.Text = "9";
                button1.Image = (Image)(new Bitmap(pictureBox9.Image, new Size(32, 32)));
                button2.Image = (Image)(new Bitmap(pictureBox9.Image, new Size(32, 32)));
                button3.Image = (Image)(new Bitmap(pictureBox9.Image, new Size(32, 32)));
                button4.Image = (Image)(new Bitmap(pictureBox9.Image, new Size(32, 32)));
                button5.Image = (Image)(new Bitmap(pictureBox9.Image, new Size(32, 32)));
                button6.Image = (Image)(new Bitmap(pictureBox9.Image, new Size(32, 32)));
                button7.Image = (Image)(new Bitmap(pictureBox9.Image, new Size(32, 32)));
                button8.Image = (Image)(new Bitmap(pictureBox9.Image, new Size(32, 32)));
                button9.Image = (Image)(new Bitmap(pictureBox9.Image, new Size(32, 32)));
                button10.Image = (Image)(new Bitmap(pictureBox9.Image, new Size(32, 32)));

                button1.Text = "9";
                button2.Text = "9";
                button3.Text = "9";
                button4.Text = "9";
                button5.Text = "9";
                button6.Text = "9";
                button7.Text = "9";
                button8.Text = "9";
                button9.Text = "9";
                button10.Text = "9";
            }
            else
            {
                o2.Text = "9";
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                button5.Visible = true;
                button6.Visible = true;
                button7.Visible = true;
                button8.Visible = true;
                button9.Visible = true;

            }
        }
        private void n0_Click(object sender, EventArgs e)
        {
            if (o1.Text == "")
            {
                o1.Text = "0";
                button1.Image = null;
                button2.Image = null;
                button3.Image = null;
                button4.Image = null;
                button5.Image = null;
                button6.Image = null;
                button7.Image = null;
                button8.Image = null;
                button9.Image = null;
                button10.Image = null;

                button1.Text = "0";
                button2.Text = "0";
                button3.Text = "0";
                button4.Text = "0";
                button5.Text = "0";
                button6.Text = "0";
                button7.Text = "0";
                button8.Text = "0";
                button9.Text = "0";
                button10.Text = "0";
            }
            else
            {
                o2.Text = "0";
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                button5.Visible = false;
                button6.Visible = false;
                button7.Visible = false;
                button8.Visible = false;
                button9.Visible = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (o1.Text != "" && o2.Text != "" && textBox1.Text != "")
            {
                if (Convert.ToDouble(textBox1.Text) == Convert.ToDouble(o1.Text) * Convert.ToDouble(o2.Text))
                {
                    answer.Text = "Correct!";
                }
                else
                {
                    answer.Text = "Wrong!";
                }
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            o1.Text = "";
            o2.Text = "";
            textBox1.Text = "";
            answer.Text = "";
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = (Image)(new Bitmap(Image.FromFile("1.png"), new Size(32, 32)));
            pictureBox2.Image = (Image)(new Bitmap(Image.FromFile("2.png"), new Size(32, 32)));
            pictureBox3.Image = (Image)(new Bitmap(Image.FromFile("3.png"), new Size(32, 32)));
            pictureBox4.Image = (Image)(new Bitmap(Image.FromFile("4.png"), new Size(32, 32)));
            pictureBox5.Image = (Image)(new Bitmap(Image.FromFile("5.png"), new Size(32, 32)));
            pictureBox6.Image = (Image)(new Bitmap(Image.FromFile("6.png"), new Size(32, 32)));
            pictureBox7.Image = (Image)(new Bitmap(Image.FromFile("7.png"), new Size(32, 32)));
            pictureBox8.Image = (Image)(new Bitmap(Image.FromFile("8.png"), new Size(32, 32)));
            pictureBox9.Image = (Image)(new Bitmap(Image.FromFile("9.png"), new Size(32, 32)));
            pictureBox10.Image = (Image)(new Bitmap(Image.FromFile("0.png"), new Size(32, 32)));

            n1.Font = new Font(n1.Font, FontStyle.Bold);
            n2.Font = new Font(n2.Font, FontStyle.Bold);
            n3.Font = new Font(n3.Font, FontStyle.Bold);
            n4.Font = new Font(n4.Font, FontStyle.Bold);
            n5.Font = new Font(n5.Font, FontStyle.Bold);
            n6.Font = new Font(n6.Font, FontStyle.Bold);
            n7.Font = new Font(n7.Font, FontStyle.Bold);
            n8.Font = new Font(n8.Font, FontStyle.Bold);
            n9.Font = new Font(n9.Font, FontStyle.Bold);
            n0.Font = new Font(n0.Font, FontStyle.Bold);

            button1.Font = new Font(n1.Font, FontStyle.Bold);
            button2.Font = new Font(n2.Font, FontStyle.Bold);
            button3.Font = new Font(n3.Font, FontStyle.Bold);
            button4.Font = new Font(n4.Font, FontStyle.Bold);
            button5.Font = new Font(n5.Font, FontStyle.Bold);
            button6.Font = new Font(n6.Font, FontStyle.Bold);
            button7.Font = new Font(n7.Font, FontStyle.Bold);
            button8.Font = new Font(n8.Font, FontStyle.Bold);
            button9.Font = new Font(n9.Font, FontStyle.Bold);
            button10.Font = new Font(n0.Font, FontStyle.Bold);
        }
    }
}
