using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1WF {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}

		private void aNUD_ValueChanged(object sender, EventArgs e) {
			update();
		}

		private void bNUD_ValueChanged(object sender, EventArgs e) {
			update();
		}

		private void cNUD_ValueChanged(object sender, EventArgs e) {
			update();
		}

		private void update() {
			var a = (double) aNUD.Value;
			var b = (double) bNUD.Value;
			var aa = (double) cNUD.Value;

			if(a <= 0 || b <= 0 || aa <= 0 || aa >= 90) {
				resultLabel.Text = "Трапеция не существует";
				return;
			}

			var area = (a + b) * Math.Abs(a - b)
				* Math.Abs(Math.Tan(aa / 180.0 * Math.PI)) * 0.25;

			if(area < 0) resultLabel.Text = "Трапеция не существует";
			else resultLabel.Text = String.Format("{0:f6}", area);
		}
	}
}
