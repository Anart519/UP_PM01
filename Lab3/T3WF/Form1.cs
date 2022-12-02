using System;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

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

		private void numericUpDown3_ValueChanged(object sender, EventArgs e) {
			update();
		}

		private static double f(double x) {
			if(x < 0) return 0.2*x*x - x - 0.1;
			else if(x > 0 && x != 0.1) return x*x / (x - 0.1);
			else if(x == 0.1) return 0;
			else return Double.NaN;//throw new Exception(); // x == 0
		}

		static void f(double x, out double y) {
			if(x < 0) y = 0.2*x*x - x - 0.1;
			else if(x > 0 && x != 0.1) y = x*x / (x - 0.1);
			else if(x == 0.1) y = 0;
			else y = Double.NaN; // x == 0
		}

		private void update() {
			double a = (double) numericUpDown1.Value;
			double b = (double) numericUpDown2.Value;
			double h = (double) numericUpDown3.Value;

			if(a > b || h == 0) {
				label4.Text = "Неправильные граныцы и/или шаг";
				return;
			}
			label4.Text = "";

			var count = (int) Math.Ceiling(Math.Abs(b - a) / h) + 1;

			double[] funcResults = new double[count];
			double[] xResults = new double[count];

			for(var i = 0; i < count; i++) {
				var x = Math.Max(Math.Min(a + i*h, b), a);
				double y;
				f(x, out y);
				xResults[i] = x;
				funcResults[i] = y;
			}

			Chart chart = chart1;     
			chart.ChartAreas.Clear();
			chart.Series.Clear();
			chart.Legends.Clear();

            ChartArea chartArea = new ChartArea();       
            chartArea.Name = "Spline";                   
            
            chartArea.AxisX.Minimum = xResults.Min();    
            chartArea.AxisX.Maximum = xResults.Max();    
            chartArea.AxisY.Minimum = funcResults.Min(); 
            chartArea.AxisY.Maximum = funcResults.Max(); 

            chartArea.AxisX.MajorGrid.Interval = h;      

            chart.ChartAreas.Add(chartArea);             

            Series series = new Series();
			series.ChartArea = "Spline";
			series.ChartType = SeriesChartType.Spline;
			series.BorderWidth = 3;

            series.LegendText = "F(x)";
			chart.Series.Add(series);

            Legend legend = new Legend();
			chart.Legends.Add(legend);

            chart.Series[0].Points.DataBindXY(xResults, funcResults);
		}
	}
}
