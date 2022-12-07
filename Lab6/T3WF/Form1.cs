using System;
using System.Text;
using System.Windows.Forms;

namespace T3WF {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}

		private void numericUpDown1_ValueChanged(object sender, EventArgs e) {
			upd();
		}

		private void numericUpDown2_ValueChanged(object sender, EventArgs e) {
			upd();
		}

		void upd() {
			var m = (int) numericUpDown1.Value;
			var k = (int) numericUpDown2.Value;

			var mat = new int[m, k];

			int num = 0;
			for(int i = 0; i < k; i++)
			for(int j = 0; j < m; j++) {
				int col;
				if(i % 2 == 0) col = j;
				else col = m-1 - j;
				mat[col, i] = num++;
			}

			var sb = new StringBuilder();

			for(int i = 0; i < m; i++, sb.Append('\n'))
			for(int j = 0; j < k; j++) 
				sb.AppendFormat("{0,5}", mat[i, j]);

			label3.Text = sb.ToString();
		}
	}
}
