using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZ_24_11_2020
{
    public partial class MainForm : Form
    {
        Graphics g;
        public MainForm()
        {
            InitializeComponent();

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            PaintFill(e);
            PaintPavn(e);
            PaintElephant(e);
            PaintCastle(e);
            PaintHorse(e);
        }

        private void PaintFill(PaintEventArgs e)
        {

            BackColor = Color.Gray;
            g = e.Graphics;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (j % 2 == 0 && i % 2 == 0)
                    {
                        g.FillRectangle(Brushes.Gold, 100 * j, 100 * i, 100, 100);

                    }
                    if (j % 2 != 0 && i % 2 != 0)
                    {
                        g.FillRectangle(Brushes.Gold, 100 * j, 100 * i, 100, 100);

                    }
                }
            }
        }

        private void PaintPavn(PaintEventArgs e)
        {
            if (g != null)
            {
                for (int i = 0; i < 8; i++)
                {
                    g.FillEllipse(Brushes.Black, 20 + i * 100, 125, 60, 60);
                    g.FillEllipse(Brushes.Black, 35 + i * 100, 100, 30, 30);
                    g.FillPie(Brushes.Black, 0 + i * 100, 165, 100, 70, 180, 180);

                    g.DrawEllipse(new Pen(Color.White, 1), 20 + i * 100, 125, 60, 60);
                    g.DrawEllipse(new Pen(Color.White, 1), 35 + i * 100, 100, 30, 30);
                    g.DrawPie(new Pen(Color.White, 1), 0 + i * 100, 165, 100, 70, 180, 180);
                }

                for (int i = 0; i < 8; i++)
                {
                    g.FillEllipse(Brushes.White, 20 + i * 100, 125 * 5, 60, 60);
                    g.FillEllipse(Brushes.White, 35 + i * 100, 100 * 6, 30, 30);
                    g.FillPie(Brushes.White, 0 + i * 100, 166 * 4, 100, 70, 180, 180);

                    g.DrawEllipse(new Pen(Color.Black, 1), 20 + i * 100, 125 * 5, 60, 60);
                    g.DrawEllipse(new Pen(Color.Black, 1), 35 + i * 100, 100 * 6, 30, 30);
                    g.DrawPie(new Pen(Color.Black, 1), 0 + i * 100, 166 * 4, 100, 70, 180, 180);
                }

            }
        }
        private void PaintElephant(PaintEventArgs e)
        {
            if (g != null)
            {


                g.FillEllipse(Brushes.Black, 243, 0, 16, 16);
                g.FillEllipse(Brushes.Black, 225, 10, 50, 80);
                g.FillPie(Brushes.Black, 200, 80, 100, 40, 180, 180);

                g.DrawEllipse(new Pen(Color.White, 1), 243, 0, 16, 16);
                g.DrawEllipse(new Pen(Color.White, 1), 225, 10, 50, 80);
                g.DrawPie(new Pen(Color.White, 1), 200, 80, 100, 40, 180, 180);

                g.FillEllipse(Brushes.Black, 543, 0, 16, 16);
                g.FillEllipse(Brushes.Black, 525, 10, 50, 80);
                g.FillPie(Brushes.Black, 500, 80, 100, 40, 180, 180);

                g.DrawEllipse(new Pen(Color.White, 1), 543, 0, 16, 16);
                g.DrawEllipse(new Pen(Color.White, 1), 525, 10, 50, 80);
                g.DrawPie(new Pen(Color.White, 1), 500, 80, 100, 40, 180, 180);

                g.FillEllipse(Brushes.White, 243, 700, 16, 16);
                g.FillEllipse(Brushes.White, 225, 710, 50, 80);
                g.FillPie(Brushes.White, 200, 780, 100, 40, 180, 180);

                g.DrawEllipse(new Pen(Color.Black, 1), 243, 700, 16, 16);
                g.DrawEllipse(new Pen(Color.Black, 1), 225, 710, 50, 80);
                g.DrawPie(new Pen(Color.Black, 1), 200, 780, 100, 40, 180, 180);

                g.FillEllipse(Brushes.White, 543, 700, 16, 16);
                g.FillEllipse(Brushes.White, 525, 710, 50, 80);
                g.FillPie(Brushes.White, 500, 780, 100, 40, 180, 180);

                g.DrawEllipse(new Pen(Color.Black, 1), 543, 700, 16, 16);
                g.DrawEllipse(new Pen(Color.Black, 1), 525, 710, 50, 80);
                g.DrawPie(new Pen(Color.Black, 1), 500, 780, 100, 40, 180, 180);

            }
        }

        private void PaintCastle(PaintEventArgs e)
        {
            if (g != null)
            {
                g.FillRectangle(Brushes.Black, 18, 0, 20, 20);
                g.FillRectangle(Brushes.Black, 40, 0, 20, 20);
                g.FillRectangle(Brushes.Black, 62, 0, 20, 20);
                g.FillPolygon(Brushes.Black, new Point[4] {
                new Point(25,10),
                new Point(75,10),
                new Point(80,90),
                new Point(20,90),
                });
                g.FillPie(Brushes.Black, 0, 80, 100, 40, 180, 180);

                g.FillRectangle(Brushes.Black, 718, 0, 20, 20);
                g.FillRectangle(Brushes.Black, 740, 0, 20, 20);
                g.FillRectangle(Brushes.Black, 762, 0, 20, 20);
                g.FillPolygon(Brushes.Black, new Point[4] {
                new Point(725,10),
                new Point(775,10),
                new Point(780,90),
                new Point(720,90),
                });
                g.FillPie(Brushes.Black, 700, 80, 100, 40, 180, 180);

                g.FillRectangle(Brushes.White, 18, 700, 20, 20);
                g.FillRectangle(Brushes.White, 40, 700, 20, 20);
                g.FillRectangle(Brushes.White, 62, 700, 20, 20);
                g.FillPolygon(Brushes.White, new Point[4] {
                new Point(25,710),
                new Point(75,710),
                new Point(80,790),
                new Point(20,790),
                });
                g.FillPie(Brushes.White, 0, 780, 100, 40, 180, 180);

                g.FillRectangle(Brushes.White, 718, 700, 20, 20);
                g.FillRectangle(Brushes.White, 740, 700, 20, 20);
                g.FillRectangle(Brushes.White, 762, 700, 20, 20);
                g.FillPolygon(Brushes.White, new Point[4] {
                new Point(725,710),
                new Point(775,710),
                new Point(780,790),
                new Point(720,790),
                });
                g.FillPie(Brushes.White, 700, 780, 100, 40, 180, 180);

            }
        }

        private void PaintHorse(PaintEventArgs e)
        {
            g.FillEllipse(Brushes.Black, 125, 10, 50, 80);
            g.FillPie(Brushes.Black, 100, 80, 100, 40, 180, 180);
        }
    }
}
