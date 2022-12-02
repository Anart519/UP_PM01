using System;

class Program {
	private static double readDouble() {
		do {
			double res;
			if(double.TryParse(Console.ReadLine(), out res)) {
				return res;
			}
			Console.Write("Ошибка. Введите ещё раз: ");
		} while(true);
	}

	private static double f(double x) {
		if(x < 0) return 0.2*x*x - x - 0.1;
		else if(x > 0 && x != 0.1) return x*x / (x - 0.1);
		else if(x == 0.1) return 0;
		else return Double.NaN; // x == 0
	}

	static void f(double x, out double y) {
		if(x < 0) y = 0.2*x*x - x - 0.1;
		else if(x > 0 && x != 0.1) y = x*x / (x - 0.1);
		else if(x == 0.1) y = 0;
		else y = Double.NaN; // x == 0
	}

	static void Main(string[] args) {
		Console.Write("Введите a: ");
		double a = readDouble();
		Console.Write("Введите b: ");
		double b = readDouble();
		Console.Write("Введите h: ");
		double h = readDouble();

		if(a > b || h == 0) {
			Console.WriteLine("Неправильные граныцы и/или шаг");
			return;
		}

		var count = (int) Math.Ceiling(Math.Abs(b - a) / h) + 1;
		for(var i = 0; i < count; i++) {
			var x = Math.Max(Math.Min(a + i*h, b), a);
			double y;
			f(x, out y);
			Console.WriteLine("f({0:f2})={1:f4}", x, y);
		}
	}
}

