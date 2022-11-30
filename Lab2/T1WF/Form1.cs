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

		private void update() {
			double x = (double) numericUpDown1.Value;
			double y = (double) numericUpDown2.Value;
			
			if(y > -x && (x*x) + (y*y) < 100) {
				label4.Text = "Внутри области";
			}
			else if(y < -x || (x*x) + (y*y) > 100) {
				label4.Text = "Снаружи области";
			}
			else label4.Text = "На границе";
		}
	}
}
