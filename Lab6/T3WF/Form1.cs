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

		void upd() {
			try {
				var n = (int) numericUpDown1.Value;
				
				var mat0 = textBox1.Text.Split(';');

				if(mat0.Length != n*n) throw new Exception(
					"Неправильное число элементов матрицы"
				);

				var mat = new int[n, n];

				for(int i = 0; i < n; i++)
				for(int j = 0; j < n; j++) {
					mat[i, j] = int.Parse(mat0[i*n + j]);
				}

				bool symmetric = true;
				for(int i = 0; i < n; i++)
				for(int j = i+1; j < n; j++) {
					if(mat[i, j] != mat[j, i]) {
						symmetric = false;
						break;
					}
				}

				label3.Text = string.Format(
					"Матрица {0}симметрична относительно главной диагонали", 
					symmetric ? "" : "не"
				);
			}
			catch(Exception e) {
				label3.Text = "Ошибка в вводе: " + e.Message;
			}
		}

		private void textBox1_TextChanged(object sender, EventArgs e) {
			upd();
		}
	}
}
