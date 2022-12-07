using System;

 class Program {
	static double f(double x) {
		var f = x*x - 2*x + 1;
		var s = 4 - 2*x;
		if(f < 0 || s <= 0) throw new Exception();

		var lns = Math.Log(s);
		if(lns == 0) throw new Exception();

		return Math.Sqrt(f) / lns;
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

