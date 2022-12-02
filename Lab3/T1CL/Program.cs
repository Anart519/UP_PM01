using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program {
	private static double methodF(double x, double y, double z) {
		var p = (x+y+z)*0.5;
		return Math.Sqrt(p * (p-x) * (p-y) * (p-z));
	}

	private static bool checkTriangleCorrect(
		double a, double b, double c
	) {
		return a > 0 && b > 0 && c > 0 
			&& 2*Math.Max(Math.Max(a, b), c) < a + b + c;
	}

	private static double calcAngle(double f, double s, double o) {
		return Math.Acos((f*f + s*s - o*o) / (2*f*s));
	}

	private static double readDouble() {
		do {
			double res;
			if(double.TryParse(Console.ReadLine(), out res)) {
				return res;
			}
			Console.Write("Ошибка. Введите ещё раз: ");
		} while(true);
	}
	static void Main(string[] args) {
		Console.Write("Введите a: ");
		var a = readDouble();
		Console.Write("Введите b: ");
		var b = readDouble();
		Console.Write("Введите c: ");
		var c = readDouble();
		Console.Write("Введите d: ");
		var d = readDouble();
		Console.Write("Введите e: ");
		var e = readDouble();
		Console.Write("Введите f: ");
		var f = readDouble();
		Console.Write("Введите g: ");
		var g = readDouble();

		var exists = checkTriangleCorrect(a, b, f)
			&& checkTriangleCorrect(f, c, g)
			&& checkTriangleCorrect(g, d, e);
		
		if(exists) {
			var ab = calcAngle(a, b, f);
			var bf = calcAngle(b, f, a);
			var af = Math.PI - ab - bf;

			var fc = calcAngle(f, c, g);
			var cg = calcAngle(c, g, f);
			var fg = Math.PI - fc - cg;

			var gd = calcAngle(g, d, e);
			var de = calcAngle(d, e, g);
			var eg = Math.PI - gd - de;

			var bc = bf + fc;
			var cd = cg + gd;
			var ea = eg + fg + af;

			//проверка многоугольника на выпуклость
			exists = ab < Math.PI
				&& bc < Math.PI
				&& cd < Math.PI
				&& de < Math.PI
				&& ea < Math.PI;
		}

		if(!exists) {
			Console.WriteLine("Пятиугольник не существует");
			return;
		}

		var s = methodF(a, b, f) +  methodF(f, c, g)
			+ methodF(g, d, e);
		Console.WriteLine("Площадь = {0}", s);
	}
}

