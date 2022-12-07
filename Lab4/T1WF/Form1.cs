using System;
using System.Windows.Forms;

namespace T1WF {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}
		
		private static uint akkerman(uint n, uint m) {
			if(n == 0) return m + 1;
			else if(m == 0) return akkerman(n-1, 1);
			else return akkerman(n-1, akkerman(n, m-1));
		}
		
		private void update() {
			var n = (uint) numericUpDown2.Value;
			var m = (uint) numericUpDown1.Value;
			
			label4.Text = "" + akkerman(n, m);
		}

		private void numericUpDown2_ValueChanged(object sender, EventArgs e) {
			update();
		}

		private void numericUpDown1_ValueChanged(object sender, EventArgs e) {
			update();
		}
	}
}