using System;
using System.Windows.Forms;

namespace T3WF {
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
			var a = (int) numericUpDown1.Value;
			var b = (int) numericUpDown2.Value;
			var n = (int) numericUpDown3.Value;

			if(a > b) {
				forl.Text = "Неправильный диапазон";
				dowhilel.Text = "Неправильный диапазон";
				whilel.Text = "Неправильный диапазон";
				return;
			}

			var s = "";

			{
				var c = 0;
				Console.WriteLine("Цикл for:");
				for(int i = a; i <= b; i++) {
					if(c >= n) break;
					if(i % 2 == 0 & i % 3 == 0) {
						s = s + i + " ";
						c++;
					}
				}
				s += "\n";
			}

			forl.Text = s;
			s = "";
			{
				var c = 0;
				int i = a;
				do {
					if(i > b) break;
					if(c >= n) break;
					if(i % 2 == 0 & i % 3 == 0) {
						s = s + i + " ";
						c++;
					}
					i++;
				} while(true);
				dowhilel.Text = s;
				s = "";
			}
			
			{
				var c = 0;
				int i = a;
				while(i <= b) {
					if(c >= n) break;
					if(i % 2 == 0 & i % 3 == 0) {
						s = s + i + " ";
						c++;
					}
					i++;
				}
				whilel.Text = s;
			}
		}

		private void numericUpDown3_ValueChanged(object sender, EventArgs e) {
			update();
		}
	}
}