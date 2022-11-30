using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1._2WF {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}

		private void textBox1_TextChanged(object sender, EventArgs e) {
			int res;
			var str = textBox1.Text;
			if(int.TryParse(str, out res)
				&& (res > 0 ? str.Length == 3 : str.Length == 4)
			) {
				int offset = res > 0 ? 0 : 1;
				var secondDigit = str[offset + 1] - '0';
				var lastDigit = str[offset + 2] - '0';
				if(secondDigit > lastDigit) {
					resultLabel.Text = "Вторая цифра больше последней";
				}
				else if(secondDigit < lastDigit) {
					resultLabel.Text = "Вторая цифра меньше последней";
				}
				else resultLabel.Text = "Вторая цифра равна последней";

				return;
			}

			resultLabel.Text = "Неправильное число";
		}
	}
}
