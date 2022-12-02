using System;
using System.Windows.Forms;

namespace T4WF {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e) {
			var s = "";
			for(int i = 1; i <= 5; i++) {
				for(int j = 0; j < i; j++) s = s + i + " ";
				s += "\n";
				for(int j = 0; j < i; j++) s = s + 0 + " ";
				s += "\n";
			}
			label1.Text = s;
		}
	}
}
