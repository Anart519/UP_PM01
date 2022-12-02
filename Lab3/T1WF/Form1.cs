using System;
using System.Windows.Forms;

namespace T1WF {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}

		private static double methodF(double x, double y, double z) {
			var p = (x + y + z) * 0.5;
			return Math.Sqrt(p * (p - x) * (p - y) * (p - z));
		}

		private static bool checkTriangleCorrect(
			double a, double b, double c
		) {
			return a > 0 && b > 0 && c > 0
				&& 2 * Math.Max(Math.Max(a, b), c) < a + b + c;
		}

		private static double calcAngle(double f, double s, double o) {
			return Math.Acos((f * f + s * s - o * o) / (2 * f * s));
		}

		private void update(object sender, EventArgs eargs) {
			var a = (double)numericUpDown1.Value;
			var b = (double)numericUpDown2.Value;
			var c = (double)numericUpDown3.Value;
			var d = (double)numericUpDown4.Value;
			var e = (double)numericUpDown5.Value;
			var f = (double)numericUpDown6.Value;
			var g = (double)numericUpDown7.Value;

			var exists = checkTriangleCorrect(a, b, f)
				&& checkTriangleCorrect(f, c, g)
				&& checkTriangleCorrect(g, d, e);

			if(exists) {
				var ab = calcAngle(a, b, f);
				var bf = calcAngle(b, f, a);
				var af = Math.PI - ab - bf;

				var fc = calcAngle(f, c, g);
				var cg = calcAngle(c, g, f);
				var fg = Math.PI - fc - cg;

				var gd = calcAngle(g, d, e);
				var de = calcAngle(d, e, g);
				var eg = Math.PI - gd - de;

				var bc = bf + fc;
				var cd = cg + gd;
				var ea = eg + fg + af;
				
				exists = ab < 2*Math.PI
					&& bc < 2*Math.PI
					&& cd < 2*Math.PI
					&& de < 2*Math.PI
					&& ea < 2*Math.PI;
			}

			if(!exists) {
				resLabel.Text = "Пятиугольник не существует";
				return;
			}

			var s = methodF(a, b, f) + methodF(f, c, g)
				+ methodF(g, d, e);
			resLabel.Text = "" + s;
		}
	}
}