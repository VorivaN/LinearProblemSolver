using LinearProblemSolving;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LinearProblem;

namespace LinearProblemSolverApplication
{
    public partial class GraphicWindow : Form
    {
        SymplexTable table = null;
        LinearProblemInstance problem = null;

        int scale = 40;
        int maxX = 15;
        int ptSize = 1;
        public GraphicWindow(SymplexTable table, LinearProblemInstance problem)
        {
            InitializeComponent();

            this.table = table;
            this.problem = problem;

            DrawGraphic();
        }


        void DrawGraphic()
        {
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            DrawAsix(maxX);

            foreach (var row in table.table)
            {
                if (row == table.table.Last()) DrawAim((double)row[0], (double)row[1], 0, new Pen(Color.Green));
                else DrawRestr((double)-row[0], (double)-row[1], (double)row[2], new Pen(Color.Blue));
            }

            FillG();
        }

        void FillG()
        {
            double d = 0.1;

            using (Graphics g = Graphics.FromImage(pictureBox1.Image))
            {
                Brush red = new SolidBrush(Color.Red);
                for (double x = 0; x <= maxX; x += d)
                {
                    for (double y = 0; y <= maxX; y += d)
                    {
                        bool ok = true;

                        foreach (var row in table.table)
                        {
                            if (row == table.table.Last()) continue;
                            if (x * (double)-row[0] + y * (double)-row[1] + (double)row[2] < 0)
                            {
                                ok = false;
                                break;
                            }
                        }
                        if (ok)
                        {
                            g.FillRectangle(red, getX(x), getY(y), ptSize, ptSize);
                        }
                    }
                }
            }
        }
        void DrawAim(double A, double B, double C, Pen p)
        {
            if (A == 0 && B == 0) return;
            if (A == 0)
            {
                using (Graphics g = Graphics.FromImage(pictureBox1.Image))
                {
                    Pen blue = new Pen(Color.Blue);
                    g.DrawLine(blue, getX(-maxX), getY(-C / B), getX(maxX), getY(-C / B));
                }
                return;
            }
            if (B == 0)
            {
                using (Graphics g = Graphics.FromImage(pictureBox1.Image))
                {
                    g.DrawLine(p, getX(-C / A), getY(-maxX), getX(-C / A), getY(maxX));
                }
                return;
            }

            using (Graphics g = Graphics.FromImage(pictureBox1.Image))
            {
                g.DrawLine(p, getX(-maxX), getY((-C + A * maxX) / B), getX(maxX), getY((-C - A * maxX) / B));
            }
        }

        void DrawRestr(double A, double B, double C, Pen p)
        {
            if (A == 0 && B == 0) return;
            if (A == 0)
            {
                using (Graphics g = Graphics.FromImage(pictureBox1.Image))
                {
                    Pen blue = new Pen(Color.Blue);
                    g.DrawLine(blue, getX(0), getY(-C / B), getX(maxX), getY(-C / B));
                }
                return;
            }
            if (B == 0)
            {
                using (Graphics g = Graphics.FromImage(pictureBox1.Image))
                {
                    g.DrawLine(p, getX(-C / A), getY(0), getX(-C / A), getY(maxX));
                }
                return;
            }

            using (Graphics g = Graphics.FromImage(pictureBox1.Image))
            {
                g.DrawLine(p, getX(0), getY(-C / B), getX(maxX), getY((-C - A * maxX) / B));
            }
        }

        void DrawAsix(int asixLen)
        {
            using (Graphics g = Graphics.FromImage(pictureBox1.Image))
            {
                g.Clear(Color.White);
                Pen black = new Pen(Color.Black);
                g.DrawLine(black, getX(0), getY(0), getX(0), getY(asixLen));
                g.DrawLine(black, getX(0), getY(0), getX(asixLen), getY(0));
                for (int i = 1; i <= asixLen; ++i)
                {
                    g.DrawLine(black, getX(i), getY(0) - 3, getX(i), getY(0) + 3);
                    g.DrawLine(black, getX(0) - 3, getY(i), getX(0) + 3, getY(i));
                }
            }
        }

        
        int getX(double x)
        {
            return 50 + (int)(x * scale);
        }
        int getY(double y)
        {
            return 400 - (int)(y * scale);
        }

        private void MaxXUpDown_ValueChanged(object sender, EventArgs e)
        {
            maxX = (int) MaxXUpDown.Value;
            DrawGraphic();
        }

        private void ScaleUpDown_ValueChanged(object sender, EventArgs e)
        {
            scale = (int)ScaleUpDown.Value;
            DrawGraphic();
        }

        private void PtSizeUpDown_ValueChanged(object sender, EventArgs e)
        {
            ptSize = (int)PtSizeUpDown.Value;
            DrawGraphic();
        }
    }
}
