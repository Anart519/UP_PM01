using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace T4WF {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}

		static int[][] divisibleBy7(int[,] a) {
			var res = new List<int[]>();
			for(int i = 0; i < a.GetLength(0); ++i)
		    for(int j = 0; j < a.GetLength(1); ++j) {
				if(a[i, j] % 7 == 0) {
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

		void upd() {
			try {
				var n = (int) numericUpDown1.Value;

				var res = textBox1.Text.Split(';')
					.Select((it) => double.Parse(it)).ToArray();
				
				if(res.Length != n * n) throw new Exception(
					"Неправильное число элементов массива"
				);

				var arr = new double[n][];
				for(int i = 0; i < n; i++) {
					arr[i] =new double[n];
					for(int j = 0; j < n; j++) {
						arr[i][j] = res[i * n + j];
					}
				}

				int k1 = (int) numericUpDown3.Value;
				if(k1 < 0 || k1 >= n) {
					throw new Exception("Неправильный номер k1");
				}
				int k2 = (int) numericUpDown4.Value;
				if(k2 < 0 || k2 >= n || k2 < k1) {
					throw new Exception("Неправильный номер k2");
				}

				var prods = new double[n];

				for(int j = 0; j < n; j++) {
					double prod = 1;
					for(int i = k1; i <= k2; i++) {
						prod *= arr[i][j];
					}
					prods[j] = prod;
				}

				var sb = new StringBuilder();
				sb.AppendFormat("Произведения столбцов от [{0}] до [{1}]: ", k1, k2);
				for(int i = 0; i < n; i++) {
					sb.AppendFormat("{0}, ", prods[i]);
				}

				label3.Text = sb.ToString();
			} 
			catch(Exception e) {
				label3.Text = "Ошибка: " + e.Message;
			}
		}

		private void numericUpDown3_ValueChanged(object sender, EventArgs e) {
			upd();
		}

		private void numericUpDown4_ValueChanged(object sender, EventArgs e) {
			upd();
		}
	}
}
