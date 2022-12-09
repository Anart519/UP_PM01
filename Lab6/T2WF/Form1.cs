using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace T2WF {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}

		private void textBox1_TextChanged(object sender, EventArgs e) {
			try {
				var arr = textBox1.Text.Split(';')
					.Select((it) => double.Parse(it)).ToArray();
				var n = arr.Length;

				var first = true;
				var min = 0.0;
				for(int i = 0; i < n; i++) {
					var it = arr[i];
					if(it > 0 && (first || it < min)) {
						first = false;
						min = it;
					}
				}
				if(first) label3.Text = "Минимального положительного элемента не существует";
				else label3.Text = string.Format("Минимальный положительный элемент = {0}", min);
			} 
			catch(Exception _) {
				label3.Text = "Ошибка в числах";
			}
		}
	}
}
