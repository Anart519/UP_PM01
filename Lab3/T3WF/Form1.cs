using System;
using System.Windows.Forms;

namespace T3WF {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}

		private void numericUpDown1_ValueChanged(object sender, EventArgs e) {
			update();
		}

		private void numericUpDown2_ValueChanged(object sender, EventArgs e) {
			update();
		}

		private void numericUpDown3_ValueChanged(object sender, EventArgs e) {
			update();
		}

		private static double f(double x) {
			if(x < 0) return 0.2*x*x - x - 0.1;
			else if(x > 0 && x != 0.1) return x*x / (x - 0.1);
			else if(x == 0.1) return 0;
			else return Double.NaN;//throw new Exception(); // x == 0
		}

		static void f(double x, out double y) {
			if(x < 0) y = 0.2*x*x - x - 0.1;
			else if(x > 0 && x != 0.1) y = x*x / (x - 0.1);
			else if(x == 0.1) y = 0;
			else y = Double.NaN; // x == 0
		}

		private void update() {
			double a = (double) numericUpDown1.Value;
			double b = (double) numericUpDown2.Value;
			double h = (double) numericUpDown3.Value;

			if(a > b || h == 0) {
				label4.Text = "Неправильные границы и/или шаг";
				label5.Text = "";
				return;
			}
			label4.Text = "";

			var count = (int) Math.Ceiling(Math.Abs(b - a) / h) + 1;

			var sb = new System.Text.StringBuilder();

			for(var i = 0; i < count; i++) {
				var x = Math.Max(Math.Min(a + i*h, b), a);
				double y;
				f(x, out y);
				sb.AppendFormat("f({0:f2})={1:f4}\n", x, y);
			}

			label5.Text = sb.ToString();
		}
	}
}
