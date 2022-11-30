using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program {
	static double readDouble() {
		do {
			double res;
			if(double.TryParse(Console.ReadLine(), out res)) {
				return res;
			}
			Console.WriteLine("Ошибка. Введите ещё раз: ");
		} while(true);
	}
	static void Main(string[] args) {
		Console.Write("Введите x: ");
		var x = readDouble();
		Console.Write("Введите y: ");
		var y = readDouble();

		if(y == -x || (x*x) + (y*y) == 100) {
			Console.WriteLine("На границе");
		}
		else if(y > -x && (x*x) + (y*y) < 100) {
			Console.WriteLine("Внутри области");
		}
		else Console.WriteLine("Снаружи области");
	}
}

