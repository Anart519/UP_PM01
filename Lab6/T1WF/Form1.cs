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

		static int[] notDivisibleBy7(int[] a) {
		    var res = new List<int>();
		    for(int i = 0; i < a.Length; ++i)
		        if(a[i] % 7 != 0) res.Add(i);
		    return res.ToArray();
		}


		private void textBox1_TextChanged(object sender, EventArgs e) {
			try {
				var res = textBox1.Text.Split(';').Select((it) => int.Parse(it));

				var dbs = notDivisibleBy7(res.ToArray());

				var sb = new StringBuilder();

				for(int i = 0; i < dbs.Length; i++) {
					sb.Append(dbs[i]).Append("; ");
				}

				label3.Text = sb.ToString();
			} 
			catch(Exception _) {
				label3.Text = "Ошибка в числах";
			}
		}
	}
}
