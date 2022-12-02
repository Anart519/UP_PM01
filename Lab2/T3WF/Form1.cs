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

			if(a > b) {
				forl.Text = "Неправильный диапазон";
				dowhilel.Text = "Неправильный диапазон";
				whilel.Text = "Неправильный диапазон";
				return;
			}

			var s = "";

			for(int i = a; i <= b; i++) {
				if(i % 2 == 0 & i % 3 == 0) {
					s = s + i + " ";
				}
			}

			forl.Text = s;
			s = "";
			{
				int i = a;
				do {
					if(i > b) break;
					if(i % 2 == 0 & i % 3 == 0) {
						s = s + i + " ";
					}
					i++;
				} while(true);
				dowhilel.Text = s;
				s = "";
			}
			
			{
				int i = a;
				while(i <= b) {
					if(i % 2 == 0 & i % 3 == 0) {
						s = s + i + " ";
					}
					i++;
				}
				whilel.Text = s;
			}
		}
	}
}