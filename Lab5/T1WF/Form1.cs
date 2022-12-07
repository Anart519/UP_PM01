using System;
using System.Windows.Forms;

namespace T1WF {
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

		static double f(double x) {
			var f = x*x - 2*x + 1;
			var s = 4 - 2*x;
			if(f < 0 || s <= 0) throw new Exception();

			var lns = Math.Log(s);
			if(lns == 0) throw new Exception();

			return Math.Sqrt(f) / lns;
		}

		void update() {
			var a = (double) numericUpDown1.Value;
			var b = (double) numericUpDown2.Value;
			var h = (double) numericUpDown3.Value;

			if(a > b || h <= 0) {
				label4.Text = "Неправильные границы и/или шаг";
				return;
			}

			var s = "";

			var count = (int)(Math.Ceiling(b - a) / h + 1);
			for(int i = 0; i < count; i++) {
				var x = a + i*h;
				try {
					var y = f(x);
					s += string.Format("f({0:f2}) = {1:f2}\n", x, y);
				} catch(Exception _) {
					s += string.Format("f({0:f2}) не определена\n", x);
				}
			}

			label4.Text = s;
		}
	}
}
