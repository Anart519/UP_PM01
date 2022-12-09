using System;

class Program {
	static double readDouble() {
		double res;
		while(!double.TryParse(Console.ReadLine(), out res))
			Console.Write("Ошибка. Введите ещё раз: ");
		return res;
	}
	static int readInt() {
		int res;
		while(!int.TryParse(Console.ReadLine(), out res))
			Console.Write("Ошибка. Введите ещё раз: ");
		return res;
	}
	static void Main(string[] args) {
		Console.Write("Введите число элементов: ");
		var n = readInt();
		if(n <= 0) {
			Console.WriteLine("Неправильный размер массива");
			return;
		}
		var arr = new double[n];
		for(int i = 0; i < n; i++) {
			Console.Write("a[{0}] = ", i);
			arr[i] = readDouble();
		}

		var first = true;
		var min = 0.0;
		for(int i = 0; i < n; i++) {
			var it = arr[i];
			if(it > 0 && (first || it < min)) {
				first = false;
				min = it;
			}
		}

		if(first) Console.WriteLine("Минимального положительного элемента не существует");
		else Console.WriteLine("Минимальный положитетльный элемент = {0}", min);
	}
}

