using System;

 class Program {
	static double f(double x) {
		var res = Math.Sqrt(x*x - 2*x + 1) / Math.Log(4 - 2*x);
		if(double.IsNaN(res)) throw new Exception();
		return res;
	}

	static double readDouble() {
		double res;
		while(!(double.TryParse(Console.ReadLine(), out res))) {
			Console.Write("Ошибка. Введите ещё раз: ");
		}
		return res;
	}

	static void Main(string[] args) {
		Console.Write("Введите a: ");
		var a = readDouble();
		Console.Write("Введите b: ");
		var b = readDouble();
		Console.Write("Введите h: ");
		var h = readDouble();

		if(a > b || h <= 0) {
			Console.WriteLine("Неправильные границы и/или шаг");
			return;
		}

		var count = (int)(Math.Ceiling(b - a) / h + 1);

		for(int i = 0; i < count; i++) {
			var x = a + i*h;
			try {
				var y = f(x);
				Console.WriteLine("f({0:f2}) = {1:f2}", x, y);
			} catch(Exception _) {
				Console.WriteLine("f({0:f2}) не определена", x);
			}
		}
	}
 }

