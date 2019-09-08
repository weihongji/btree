using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BTree
{
	public partial class Form1 : Form
	{
		public Form1() {
			InitializeComponent();
		}

		private class Circle
		{
			public Point center;
			public int radius;

			public Circle(int x, int y, int r)
				: this(new Point(x, y), r) {
			}

			public Circle(Point p, int r) {
				center = p;
				radius = r;
			}
		}

		private List<Circle> GetCircles(int count = 1) {
			var list = new List<Circle>();
			int r = 30;
			int interval = 20;
			int distance = 2 * r + interval;
			for (int i = 0; i < count; i++) {
				list.Add(new Circle(r + interval / 2 + distance * i, r + interval / 2, r));
			}
			return list;
		}

		private void DrawCircles(Circle circle, Graphics g = null, Pen p = null) {
			DrawCircles(new List<Circle>() { circle }, g, p);
		}

		private void DrawCircles(List<Circle> list, Graphics g = null, Pen p = null) {
			panel1.Refresh();
			if (g == null) {
				g = GetGraphics();
			}
			if (p == null) {
				p = GetPen(Color.FromArgb(0, 0, 0));
			}
			for (int i = 0; i < list.Count; i++) {
				DrawCircle(list[i], (i + 1).ToString(), g, p);
			}
		}

		private void DrawCircle(Circle c, String text, Graphics g = null, Pen p = null) {
			if (c == null || c.radius <= 0) {
				return;
			}
			if (g == null) {
				g = GetGraphics();
			}
			if (p == null) {
				p = GetPen();
			}
			g.DrawEllipse(p, c.center.X - c.radius, c.center.Y - c.radius, c.radius * 2, c.radius * 2);
			//g.DrawEllipse(p, c.center.X, c.center.Y, 1, 1); // Center point
			//g.FillEllipse(new SolidBrush(p.Color), c.center.X - c.radius, c.center.Y - c.radius, c.radius * 2, c.radius * 2);

			Font font = new Font("Arial", 10);
			g.DrawString(text, font, p.Brush, c.center.X - 5, c.center.Y - font.Height / 2);
		}

		private Graphics GetGraphics() {
			var g = panel1.CreateGraphics();
			g.SmoothingMode = SmoothingMode.AntiAlias;
			return g;
		}

		private Pen GetPen(Color c = new Color(), int width = 1) {
			var p = new Pen(c, width);
			return p;
		}

		private void menuFile_Circle1_Click(object sender, EventArgs e) {
			DrawCircles(GetCircles(), null, new Pen(Color.Red));
		}

		private void menuFile_Circle2_Click(object sender, EventArgs e) {
			DrawCircles(GetCircles(2), null, new Pen(Color.Green));
		}

		private void menuFile_Circle3_Click(object sender, EventArgs e) {
			DrawCircles(GetCircles(3), null, new Pen(Color.Purple));
		}

		private void menuFile_BTree_Click(object sender, EventArgs e) {
			int r = 20;
			int a = 20; // Distance between border of left and right leaves
			int b = 30; // Distance between border of left leaf and the root.
			int h = (int)Math.Round(Math.Sqrt(Math.Pow(b + 2 * r, 2) - Math.Pow(r + a / 2, 2)), 0);
			Point A = new Point(2 * r + a / 2, r);
			Point B = new Point(r, h + r);
			Point C = new Point(3 * r + a, h + r);

			int x0 = a / 2; // Left position from which drawing starts.
			int y0 = x0; // Top position from which drawing starts.
			Size offset = new Size(x0, y0);
			A = Point.Add(A, offset);
			B = Point.Add(B, offset);
			C = Point.Add(C, offset);

			List<Circle> list = new List<Circle>();
			list.Add(new Circle(A, r));
			list.Add(new Circle(B, r));
			list.Add(new Circle(C, r));

			var g = GetGraphics();
			var pen = new Pen(Color.Blue);
			DrawCircles(list, g, pen);
			//g.DrawLines(pen, new Point[] { A, B, C, A });

			int xb, yb; // Coordinate of point line crossing circle border.

			// A-B at A's border
			xb = (int)Math.Round((double)r / (b + 2 * r) * (B.X - A.X), 0) + A.X;
			yb = (int)Math.Round((double)r / (b + 2 * r) * (B.Y - A.Y), 0) + A.Y;
			var AB = new Point(xb, yb);

			// A-B at B's border
			xb = (int)Math.Round((double)r / (b + 2 * r) * (A.X - B.X), 0) + B.X;
			yb = (int)Math.Round((double)r / (b + 2 * r) * (A.Y - B.Y), 0) + B.Y;
			var BA = new Point(xb, yb);

			// A-C at A's border
			xb = (int)Math.Round((double)r / (b + 2 * r) * (C.X - A.X), 0) + A.X;
			yb = (int)Math.Round((double)r / (b + 2 * r) * (C.Y - A.Y), 0) + A.Y;
			var AC = new Point(xb, yb);

			// A-C at C's border
			xb = (int)Math.Round((double)r / (b + 2 * r) * (A.X - C.X), 0) + C.X;
			yb = (int)Math.Round((double)r / (b + 2 * r) * (A.Y - C.Y), 0) + C.Y;
			var CA = new Point(xb, yb);

			g.DrawLine(pen, AB, BA);
			g.DrawLine(pen, AC, CA);
		}

		private void menuFile_Exit_Click(object sender, EventArgs e) {
			Application.Exit();
		}
	}
}
