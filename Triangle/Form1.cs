using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using System.Drawing;
using System.Drawing.Drawing2D;

namespace Triangle
{
    public partial class Form1 : Form
    {
        // Selected triangles.
        private List<Point> Triangles = new List<Point>();

        public Form1()
        {
            InitializeComponent();

            //TriangleToPoints(10, 6, 12);
        }

        // Redraw the grid.
        private void picGrid_Paint(object sender, PaintEventArgs e)
        {
            //Point[] points = { new Point(10, 0), new Point(10, 10), new Point(0, 0) };
            //e.Graphics.DrawPolygon(new Pen(Color.Blue), points);

            int yl1 = 10;
            int yl2 = 10;
            int yl3 = 0;
            for (int j = 0; j < 5; j++)
            {
                int x1 = 0;
                int x2 = 10;
                int x3 = 0;
                for (int i = 0; i < 6; i++)
                {
                    Point[] points = { new Point(x1, yl1), new Point(x2, yl2), new Point(x3, yl3) };
                    e.Graphics.DrawPolygon(new Pen(Color.Blue), points);

                    if (v2x.Text == x1.ToString() && v2y.Text == yl1.ToString() && v1x.Text == x2.ToString() && v1y.Text == yl2.ToString() && v3x.Text == x3.ToString() && v3y.Text == yl3.ToString())
                    {
                        MessageBox.Show("Row number is " + j.ToString() + " and Column number is " + i.ToString());
                    }
                    x1 += 10;
                    x2 += 10;
                    x3 += 10;
                }
                yl1 += 10;
                yl2 += 10;
                yl3 += 10;
            }
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            int yl1 = 10;
            int yl2 = 10;
            int yl3 = 0;
            for (int j = 0; j < 5; j++)
            {
                int x1 = 0;
                int x2 = 10;
                int x3 = 0;
                for (int i = 0; i < 6; i++)
                {
                    Point[] points = { new Point(x1, yl1), new Point(x2, yl2), new Point(x3, yl3) };
                    //e.Graphics.DrawPolygon(new Pen(Color.Blue), points);

                    if (v2x.Text == x1.ToString() && v2y.Text == yl1.ToString() && v1x.Text == x2.ToString() && v1y.Text == yl2.ToString() && v3x.Text == x3.ToString() && v3y.Text == yl3.ToString())
                    {
                        MessageBox.Show("Row number is " + j.ToString() + " and Column number is " + i.ToString());
                    }
                    x1 += 10;
                    x2 += 10;
                    x3 += 10;
                }
                yl1 += 10;
                yl2 += 10;
                yl3 += 10;
            }
            //e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
        }
    }
}
