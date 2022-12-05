using System;
using System.Text;
using System.Windows.Forms;

namespace T2WF {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();

			update();
		}
		static StringBuilder print(int n, int row = 1, StringBuilder sb = null) {
			if(sb == null) sb = new StringBuilder();
			var cols = row * 2 - 1;
			if(cols < n) {
				for (int i = 0; i < n /2- cols/2; i++) sb.Append(" ");
				for (int i = 0; i < cols; i++) sb.Append(row);
				sb.Append("\n");
				sb = print(n, row+1, sb);
				for (int i = 0; i < n /2- cols/2; i++) sb.Append(" ");
				for (int i = 0; i < cols; i++) sb.Append(row);
				sb.Append("\n");
			}
			else {
				for (int i = 0; i < n; i++) sb.Append(row);
				sb.Append("\n");
			}
			return sb;
		}

		private void numericUpDown1_ValueChanged(object sender, EventArgs e) {
			update();
		}

		private void update() {
			var s = print((int) numericUpDown1.Value).ToString();
			label3.Text = s;
		}
	}
}
