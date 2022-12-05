using System;

class Program {
	static int readInt() {
		int res;
		while(!int.TryParse(Console.ReadLine(), out res)) {
			Console.Write("Ошибка. Введите ещё раз: ");
		}
		return res;
	}

	static void Main(string[] args) {
		Console.Write("Введите A: ");
		var a = readInt();
		Console.Write("Введите B: ");
		var b = readInt();
		Console.Write("Введите N: ");
		var n = readInt();

		if(a > b) {
			Console.WriteLine("Неправильный диапазон");
			return;
		}
		if(n < 0) {
			Console.WriteLine("Неправильное число чисел");
			return;
		}

		{
			var c = 0;
			Console.WriteLine("Цикл for:");
			for(int i = a; i <= b; i++) {
				if(c >= n) break;
				if(i % 2 == 0 & i % 3 == 0) {
					Console.Write(i + " ");
					c++;
				}
			}
			Console.WriteLine();
		}

		Console.WriteLine("Цикл do while:");
		{
			var c = 0;
			int i = a;
			do {
				if(i > b) break;
				if(c >= n) break;
				if(i % 2 == 0 & i % 3 == 0) {
					Console.Write(i + " ");
					c++;
				}
				i++;
			} while(true);
			Console.WriteLine();
		}

		Console.WriteLine("Цикл while:");
		{
			var c = 0;
			int i = a;
			while(i <= b) {
				if(c >= n) break;
				if(i % 2 == 0 & i % 3 == 0) {
					Console.Write(i + " ");
					c++;
				}
				i++;
			}
			Console.WriteLine();
		}
	}
}