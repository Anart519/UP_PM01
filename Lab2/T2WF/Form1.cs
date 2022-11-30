using System;
using System.Windows.Forms;

namespace T2WF {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}

		private void numericUpDown1_ValueChanged(object sender, EventArgs e) {
			var year = (int) numericUpDown1.Value;
			if(year <= 0) {
				label3.Text = "Введён неправильный номер года";
				return;
			}
			var animals = new[]{
				"обезьяна", "петух", "собака", "свинья",	
				"крыса", "буйвол", "тигр", "кролик",	
				"дракон", "змея", "лошадь", "коза"
			};
			string b;
			switch(year % 12) {
				case 0: b = animals[0]; break;
				case 1: b = animals[1]; break;
				case 2: b = animals[2]; break;
				case 3: b = animals[3]; break;
				case 4: b = animals[4]; break;
				case 5: b = animals[5]; break;
				case 6: b = animals[6]; break;
				case 7: b = animals[7]; break;
				case 8: b = animals[8]; break;
				case 9: b = animals[9]; break;
				case 10: b = animals[10]; break;
				case 11: b = animals[11]; break;
				default: throw new Exception();
			}
			label3.Text = string.Format(
				"{1} год по восточному календарю символизирует {0}",
				b, year
			);
		}
	}
}
