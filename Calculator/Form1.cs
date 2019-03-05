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
        PictureBox fruits;
        Panel panel1 = new Panel
        {
            Name = "panel1",
            Size = new Size(42, 42),
            Visible = true,
            Location = new Point(23, 213)
        };
        public Form1()
        {
            InitializeComponent();
        }

        public void n1_Click(object sender, EventArgs e)
        {
            if (o1.Text == "")
            {
                o1.Text = "1";
                subject.Text = "Subject: Cherry";

                for (int i = 0; i < 1; i++)
                {
                    PictureBox fruits = new PictureBox
                    {
                        Name = "pictureBox",
                        Size = new Size(8, 8),
                        Location = new Point((14 + 25), (215 + 14)),
                        Visible = true,
                        Image = (Image)(new Bitmap(Image.FromFile("1.png"), new Size(8, 8))),
                    };
                    panel1.Controls.Add(fruits);
                    panel1.BorderStyle = BorderStyle.FixedSingle;
                    this.Controls.Add(fruits);
                    fruits.Show();
                }
                this.Controls.Add(panel1);
                panel1.Show();
            }
            else
            {
                o2.Text = "1";
                fruitsLayout();

            }
        }
        public void n2_Click(object sender, EventArgs e)
        {
            if (o1.Text == "")
            {
                o1.Text = "2";
                subject.Text = "Subject: Cabbage";

                for (int i = 0; i < 2; i++)
                {
                    PictureBox fruits = new PictureBox
                    {
                        Name = "pictureBox",
                        Size = new Size(8, 8),
                        Location = new Point(14 + 25, 215 + 14 * (i * 2)),
                        Visible = true,
                        Image = (Image)(new Bitmap(Image.FromFile("2.png"), new Size(8, 8))),
                    };
                    panel1.Controls.Add(fruits);
                    panel1.BorderStyle = BorderStyle.FixedSingle;
                    this.Controls.Add(fruits);
                    fruits.Show();
                }
                this.Controls.Add(panel1);
                panel1.Show();
            }
            else
            {
                o2.Text = "2";
                fruitsLayout();

            }
        }
        public void n3_Click(object sender, EventArgs e)
        {
            if (o1.Text == "")
            {
                o1.Text = "3";
                subject.Text = "Subject: Coconut";

                for (int i = 0; i < 3; i++)
                {
                    PictureBox start_picture = new PictureBox
                    {
                        Name = "pictureBox",
                        Size = new Size(8, 8),
                        Location = new Point((14 + 25), 215 + i * 14),
                        Visible = true,
                        Image = (Image)(new Bitmap(Image.FromFile("3.png"), new Size(8, 8))),

                    };
                    panel1.Controls.Add(fruits);
                    panel1.BorderStyle = BorderStyle.FixedSingle;
                    this.Controls.Add(start_picture);
                    start_picture.Show();
                }
                this.Controls.Add(panel1);
                panel1.Show();
            }
            else
            {
                o2.Text = "3";
                fruitsLayout();

            }
        }
        public void n4_Click(object sender, EventArgs e)
        {
            if (o1.Text == "")
            {
                o1.Text = "4";
                subject.Text = "Subject: Pinapple";

                for (int i = 0; i < 4; i++)
                {
                    PictureBox fruits = new PictureBox
                    {
                        Name = "pictureBox",
                        Size = new Size(8, 8),
                        Location = new Point((28 * (i % 2)) + 25, 215 + (int)(i / 2) * 28),
                        Visible = true,
                        Image = (Image)(new Bitmap(Image.FromFile("4.png"), new Size(8, 8))),
                    };
                    panel1.Controls.Add(fruits);
                    panel1.BorderStyle = BorderStyle.FixedSingle;
                    this.Controls.Add(fruits);
                    fruits.Show();
                }
                this.Controls.Add(panel1);
                panel1.Show();
            }
            else
            {
                o2.Text = "4";
                fruitsLayout();

            }
        }
        public void n5_Click(object sender, EventArgs e)
        {
            if (o1.Text == "")
            {
                o1.Text = "5";
                subject.Text = "Subject: Orange";

                for (int i = 0; i < 5; i++)
                {
                    PictureBox fruits;
                    if (i == 4)
                    {
                        fruits = new PictureBox
                        {
                            Name = "pictureBox",
                            Size = new Size(8, 8),
                            Location = new Point(39,229),
                            Visible = true,
                            Image = (Image)(new Bitmap(Image.FromFile("5.png"), new Size(8, 8))),
                        };
                    }
                    else
                    {
                        fruits = new PictureBox
                        {
                            Name = "pictureBox",
                            Size = new Size(8, 8),
                            Location = new Point((28 * (i % 2)) + 25, 215 + (int)(i / 2) * 28),
                            Visible = true,
                            Image = (Image)(new Bitmap(Image.FromFile("5.png"), new Size(8, 8))),
                        };
                    }
                    panel1.Controls.Add(fruits);
                    panel1.BorderStyle = BorderStyle.FixedSingle;
                    this.Controls.Add(fruits);
                    fruits.Show();
                }
                this.Controls.Add(panel1);
                panel1.Show();
            }
            else
            {
                o2.Text = "5";
                fruitsLayout();

            }
        }
        public void n6_Click(object sender, EventArgs e)
        {
            if (o1.Text == "")
            {
                o1.Text = "6";
                subject.Text = "Subject: Peach";

                for (int i = 0; i < 6; i++)
                {
                    PictureBox fruits = new PictureBox
                    {
                        Name = "pictureBox",
                        Size = new Size(8, 8),
                        Location = new Point((28 * (i % 2)) + 25, 215 + (int)(i / 2) * 14),
                        Visible = true,
                        Image = (Image)(new Bitmap(Image.FromFile("6.png"), new Size(8, 8))),
                    };
                    panel1.Controls.Add(fruits);
                    panel1.BorderStyle = BorderStyle.FixedSingle;
                    this.Controls.Add(fruits);
                    fruits.Show();
                }
                this.Controls.Add(panel1);
                panel1.Show();
            }
            else
            {
                o2.Text = "6";
                fruitsLayout();
            }
        }
        public void n7_Click(object sender, EventArgs e)
        {
            if (o1.Text == "")
            {
                o1.Text = "7";
                subject.Text = "Subject: Pumpkin";

                for (int i = 0; i < 7; i++)
                {
                    PictureBox fruits;
                    if (i == 6)
                    {
                        fruits = new PictureBox
                        {
                            Name = "pictureBox",
                            Size = new Size(8, 8),
                            Location = new Point(39,222),
                            Visible = true,
                            Image = (Image)(new Bitmap(Image.FromFile("7.png"), new Size(8, 8))),
                        };
                    }
                    else
                    {
                        fruits = new PictureBox
                        {
                            Name = "pictureBox",
                            Size = new Size(8, 8),
                            Location = new Point((28 * (i % 2)) + 25, 215 + (int)(i / 2) * 14),
                            Visible = true,
                            Image = (Image)(new Bitmap(Image.FromFile("7.png"), new Size(8, 8))),
                        };
                    }
                    panel1.Controls.Add(fruits);
                    panel1.BorderStyle = BorderStyle.FixedSingle;
                    this.Controls.Add(fruits);
                    fruits.Show();
                }
                this.Controls.Add(panel1);
                panel1.Show();
            }
            else
            {
                o2.Text = "7";
                fruitsLayout();

            }
        }
        public void n8_Click(object sender, EventArgs e)
        {
            if (o1.Text == "")
            {
                o1.Text = "8";
                subject.Text = "Subject: Raspberry";

                for (int i = 0; i < 8; i++)
                {
                    PictureBox fruits;
                    if (i == 6)
                    {
                        fruits = new PictureBox
                        {
                            Name = "pictureBox",
                            Size = new Size(8, 8),
                            Location = new Point(39, 222),
                            Visible = true,
                            Image = (Image)(new Bitmap(Image.FromFile("8.png"), new Size(8, 8))),
                        };
                    }
                    else if (i == 7)
                    {
                        fruits = new PictureBox
                        {
                            Name = "pictureBox",
                            Size = new Size(8, 8),
                            Location = new Point(39,235),
                            Visible = true,
                            Image = (Image)(new Bitmap(Image.FromFile("8.png"), new Size(8, 8))),
                        };
                    }
                    else
                    {
                        fruits = new PictureBox
                        {
                            Name = "pictureBox",
                            Size = new Size(8, 8),
                            Location = new Point((28 * (i % 2)) + 25, 215 + (int)(i / 2) * 14),
                            Visible = true,
                            Image = (Image)(new Bitmap(Image.FromFile("8.png"), new Size(8, 8))),
                        };
                    }
                    panel1.Controls.Add(fruits);
                    panel1.BorderStyle = BorderStyle.FixedSingle;
                    this.Controls.Add(fruits);
                    fruits.Show();
                }
                this.Controls.Add(panel1);
                panel1.Show();
            }
            else
            {
                o2.Text = "8";
                fruitsLayout();

            }
        }
        public void n9_Click(object sender, EventArgs e)
        {
            if (o1.Text == "")
            {
                o1.Text = "9";
                subject.Text = "Subject: Tomato";

                for (int i = 0; i < 9; i++)
                {
                    PictureBox fruits;
                    if (i == 8)
                    {
                        fruits = new PictureBox
                        {
                            Name = "pictureBox",
                            Size = new Size(8, 8),
                            Location = new Point(39, 229),
                            Visible = true,
                            Image = (Image)(new Bitmap(Image.FromFile("9.png"), new Size(8, 8))),
                        };
                    }
                    else
                    {
                        fruits = new PictureBox
                        {
                            Name = "pictureBox",
                            Size = new Size(8, 8),
                            Location = new Point((28 * (i % 2)) + 25, 215 + (int)(i / 2) * 10),
                            Visible = true,
                            Image = (Image)(new Bitmap(Image.FromFile("9.png"), new Size(8, 8))),
                        };
                    }
                    panel1.Controls.Add(fruits);
                    panel1.BorderStyle = BorderStyle.FixedSingle;
                    this.Controls.Add(fruits);
                    fruits.Show();
                }
                this.Controls.Add(panel1);
                panel1.Show();
            }
            else
            {
                o2.Text = "9";
                fruitsLayout();
            }
        }

        public void n0_Click(object sender, EventArgs e)
        {
            if (o1.Text == "")
            {
                o1.Text = "0";
                subject.Text = "Subject: Strawberry";

            }
            else
            {
                o2.Text = "0";
                foreach (var lbl in Controls.OfType<PictureBox>().Where(x => x.Name == "pictureBox"))
                    lbl.Hide();
                foreach (var lbl in Controls.OfType<Panel>().Where(x => x.Name == "panel1"))
                    lbl.Hide();
            }
        }

        public async void textBox1_TextChanged(object sender, EventArgs e)
        {
            await Task.Delay(1000);
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
                if (o2.Text == "0")
                {
                    procedure.Text = "0";
                }
                else
                {
                    procedure.Text = o1.Text;
                }
                for (int i = 1; i < Int32.Parse(o2.Text); i++)
                {
                    procedure.Text += "+" + o1.Text;
                }
                procedure.Text += " = " + Convert.ToDouble(o1.Text) * Convert.ToDouble(o2.Text);
            }
        }

        public void clear_Click(object sender, EventArgs e)
        {
            o1.Text = "";
            o2.Text = "";
            textBox1.Text = "";
            answer.Text = "";
            procedure.Text = "";
            foreach (var lbl in Controls.OfType<PictureBox>().Where(x => x.Name == "pictureBox"))
                lbl.Hide();
            foreach (var lbl in Controls.OfType<Panel>().Where(x => x.Name == "panel1"))
                lbl.Hide();
            subject.Text = "Subject: ";
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            pictureBox0.Image = (Image)(new Bitmap(Image.FromFile("0.png"), new Size(32, 32)));
            pictureBox1.Image = (Image)(new Bitmap(Image.FromFile("1.png"), new Size(32, 32)));
            pictureBox2.Image = (Image)(new Bitmap(Image.FromFile("2.png"), new Size(32, 32)));
            pictureBox3.Image = (Image)(new Bitmap(Image.FromFile("3.png"), new Size(32, 32)));
            pictureBox4.Image = (Image)(new Bitmap(Image.FromFile("4.png"), new Size(32, 32)));
            pictureBox5.Image = (Image)(new Bitmap(Image.FromFile("5.png"), new Size(32, 32)));
            pictureBox6.Image = (Image)(new Bitmap(Image.FromFile("6.png"), new Size(32, 32)));
            pictureBox7.Image = (Image)(new Bitmap(Image.FromFile("7.png"), new Size(32, 32)));
            pictureBox8.Image = (Image)(new Bitmap(Image.FromFile("8.png"), new Size(32, 32)));
            pictureBox9.Image = (Image)(new Bitmap(Image.FromFile("9.png"), new Size(32, 32)));

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
        }

        public void fruitsLayout()
        {
            foreach (var lbl in Controls.OfType<PictureBox>().Where(x => x.Name == "pictureBox"))
                lbl.Hide();
            foreach (var lbl in Controls.OfType<Panel>().Where(x => x.Name == "panel1"))
                lbl.Hide();
            for (int j = 0; j < Int32.Parse(o2.Text); j++)
            {
                Panel panel1 = new Panel
                {
                    Name = "panel1",
                    Size = new Size(42, 42),
                    Visible = true,
                    BorderStyle = BorderStyle.FixedSingle,
                    Location = new Point(23 + (j * 47), 213)
                };
                for (int i = 0; i < Int32.Parse(o1.Text); i++)
                {
                    switch (Int32.Parse(o1.Text))
                    {
                        case 0:
                            break;
                        case 1:
                            fruits = new PictureBox
                            {
                                Name = "pictureBox",
                                Size = new Size(8, 8),
                                Location = new Point(14 + 25 + (j * 47), 215 + 14),
                                Visible = true,
                                Image = (Image)(new Bitmap(Image.FromFile(Int32.Parse(o1.Text) + ".png"), new Size(8, 8))),
                            };
                            panel1.Controls.Add(fruits);
                            this.Controls.Add(fruits);
                            fruits.Show();
                            break;
                        case 2:
                            fruits = new PictureBox
                            {
                                Name = "pictureBox",
                                Size = new Size(8, 8),
                                Location = new Point(14 + 25 + (j * 47), 215 + 14 * (i*2)),
                                Visible = true,
                                Image = (Image)(new Bitmap(Image.FromFile(Int32.Parse(o1.Text) + ".png"), new Size(8, 8))),
                            };
                            panel1.Controls.Add(fruits);
                            this.Controls.Add(fruits);
                            fruits.Show();
                            break;
                        case 3:
                            fruits = new PictureBox
                            {
                                Name = "pictureBox",
                                Size = new Size(8, 8),
                                Location = new Point(14 + 25 + (j * 47), 215 + 14 * i),
                                Visible = true,
                                Image = (Image)(new Bitmap(Image.FromFile(Int32.Parse(o1.Text) + ".png"), new Size(8, 8))),
                            };
                            panel1.Controls.Add(fruits);
                            this.Controls.Add(fruits);
                            fruits.Show();
                            break;
                        case 4:
                            fruits = new PictureBox
                            {
                                Name = "pictureBox",
                                Size = new Size(8, 8),
                                Location = new Point((28 * (i % 2)) + 25 + (j * 47), 215 + (int)(i / 2) * 28),
                                Visible = true,
                                Image = (Image)(new Bitmap(Image.FromFile(Int32.Parse(o1.Text) + ".png"), new Size(8, 8))),
                            };
                            panel1.Controls.Add(fruits);
                            this.Controls.Add(fruits);
                            fruits.Show();
                            break;
                        case 5:
                            if (i == 4)
                            {
                                fruits = new PictureBox
                                {
                                    Name = "pictureBox",
                                    Size = new Size(8, 8),
                                    Location = new Point(39 + (j * 47), 229),
                                    Visible = true,
                                    Image = (Image)(new Bitmap(Image.FromFile(Int32.Parse(o1.Text) + ".png"), new Size(8, 8))),
                                };
                            }
                            else
                            {
                                fruits = new PictureBox
                                {
                                    Name = "pictureBox",
                                    Size = new Size(8, 8),
                                    Location = new Point((28 * (i % 2)) + 25 + (j * 47), 215 + (int)(i / 2) * 28),
                                    Visible = true,
                                    Image = (Image)(new Bitmap(Image.FromFile(Int32.Parse(o1.Text) + ".png"), new Size(8, 8))),
                                };
                            }
                            panel1.Controls.Add(fruits);
                            this.Controls.Add(fruits);
                            fruits.Show();
                            break;
                        case 6:
                            fruits = new PictureBox
                            {
                                Name = "pictureBox",
                                Size = new Size(8, 8),
                                Location = new Point((28 * (i % 2)) + 25 + (j * 47), 215 + (int)(i / 2) * 14),
                                Visible = true,
                                Image = (Image)(new Bitmap(Image.FromFile(Int32.Parse(o1.Text) + ".png"), new Size(8, 8))),
                            };
                            panel1.Controls.Add(fruits);
                            this.Controls.Add(fruits);
                            fruits.Show();
                            break;
                        case 7:
                            if (i == 6)
                            {
                                fruits = new PictureBox
                                {
                                    Name = "pictureBox",
                                    Size = new Size(8, 8),
                                    Location = new Point(39 + (j * 47), 222),
                                    Visible = true,
                                    Image = (Image)(new Bitmap(Image.FromFile(Int32.Parse(o1.Text) + ".png"), new Size(8, 8))),
                                };
                            }
                            else
                            {
                                fruits = new PictureBox
                                {
                                    Name = "pictureBox",
                                    Size = new Size(8, 8),
                                    Location = new Point((28 * (i % 2)) + 25 + (j * 47), 215 + (int)(i / 2) * 14),
                                    Visible = true,
                                    Image = (Image)(new Bitmap(Image.FromFile(Int32.Parse(o1.Text) + ".png"), new Size(8, 8))),
                                };
                            }
                            panel1.Controls.Add(fruits);
                            this.Controls.Add(fruits);
                            fruits.Show();
                            break;
                        case 8:
                            if (i == 6)
                            {
                                fruits = new PictureBox
                                {
                                    Name = "pictureBox",
                                    Size = new Size(8, 8),
                                    Location = new Point(39 + (j * 47), 222),
                                    Visible = true,
                                    Image = (Image)(new Bitmap(Image.FromFile(Int32.Parse(o1.Text) + ".png"), new Size(8, 8))),
                                };
                            }
                            else if (i == 7)
                            {
                                fruits = new PictureBox
                                {
                                    Name = "pictureBox",
                                    Size = new Size(8, 8),
                                    Location = new Point(39 + (j * 47), 235),
                                    Visible = true,
                                    Image = (Image)(new Bitmap(Image.FromFile(Int32.Parse(o1.Text) + ".png"), new Size(8, 8))),
                                };
                            }
                            else
                            {
                                fruits = new PictureBox
                                {
                                    Name = "pictureBox",
                                    Size = new Size(8, 8),
                                    Location = new Point((28 * (i % 2)) + 25 + (j * 47), 215 + (int)(i / 2) * 14),
                                    Visible = true,
                                    Image = (Image)(new Bitmap(Image.FromFile(Int32.Parse(o1.Text) + ".png"), new Size(8, 8))),
                                };
                            }
                            panel1.Controls.Add(fruits);
                            this.Controls.Add(fruits);
                            fruits.Show();
                            break;
                        case 9:
                            if (i == 8)
                            {
                                fruits = new PictureBox
                                {
                                    Name = "pictureBox",
                                    Size = new Size(8, 8),
                                    Location = new Point(39 + (j * 47), 229),
                                    Visible = true,
                                    Image = (Image)(new Bitmap(Image.FromFile(Int32.Parse(o1.Text) + ".png"), new Size(8, 8))),
                                };
                            }
                            else
                            {
                                fruits = new PictureBox
                                {
                                    Name = "pictureBox",
                                    Size = new Size(8, 8),
                                    Location = new Point((28 * (i % 2)) + 25 + (j * 47), 215 + (int)(i / 2) * 10),
                                    Visible = true,
                                    Image = (Image)(new Bitmap(Image.FromFile(Int32.Parse(o1.Text) + ".png"), new Size(8, 8))),
                                };
                            }
                            panel1.Controls.Add(fruits);
                            this.Controls.Add(fruits);
                            fruits.Show();
                            break;
                        default:
                            break;
                    }
                }
                this.Controls.Add(panel1);

            }
        }
    }
}
