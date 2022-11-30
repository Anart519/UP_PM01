using System;
class Program {
	private static double readDouble() {
		do {
			double result;
			if(double.TryParse(Console.ReadLine(), out result)) {
				return result;
			}
			else Console.WriteLine("Ошибка. Повторите ввод: ");
		} while(true);
	}

	static void Main(string[] args) {
		Console.Write("Введите основание a: ");
		var a = readDouble();
		Console.Write("Введите основание b: ");
		var b = readDouble();
		Console.Write("Введите угол alpha в градусах: ");
		var aa = readDouble();

		if(a <= 0 || b <= 0 || aa <= 0 || aa >= 90) {
			Console.WriteLine("Трапеция не существует");
			return;
		}

		var area = (a+b) * Math.Abs(a-b)
			* Math.Tan(aa/180.0*Math.PI) * 0.25;
		
		Console.WriteLine("Площадь трапеции равна {0}", area);
	}
}