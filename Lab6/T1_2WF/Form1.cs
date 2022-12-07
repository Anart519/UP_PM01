using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace T1WF {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}

		static int[][] notDivisibleBy7(int[,] a) {
			var res = new List<int[]>();
			for(int i = 0; i < a.GetLength(0); ++i)
		    for(int j = 0; j < a.GetLength(1); ++j) {
				if(a[i, j] % 7 != 0) {
					res.Add(new[]{i, j});
				}
			}
			return res.ToArray();
		}


		private void textBox1_TextChanged(object sender, EventArgs e) {
			upd();
		}

		private void numericUpDown1_ValueChanged(object sender, EventArgs e) {
			upd();
		}

		private void numericUpDown2_ValueChanged(object sender, EventArgs e) {
			upd();
		}

		void upd() {
			try {
				var n = (int) numericUpDown1.Value;
				var m = (int) numericUpDown2.Value;

				var res = textBox1.Text.Split(';')
					.Select((it) => int.Parse(it)).ToArray();;
				
				if(res.Length != n * m) throw new Exception();

				var res2 = new int[n, m];
				for(int i = 0; i < n; i++)
				for(int j = 0; j < m; j++) {
					res2[i, j] = res[i * m + j];
				}

				var dbs = notDivisibleBy7(res2);

				var sb = new StringBuilder();

				for(int i = 0; i < dbs.Length; i++) {
					sb.AppendFormat("({0}; {1});", dbs[i][0], dbs[i][1]);
				}

				label3.Text = sb.ToString();
			} 
			catch(Exception _) {
				label3.Text = "Ошибка в числах";
			}
		}
	}
}
