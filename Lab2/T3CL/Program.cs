using System;

class Program {
	static int readInt() {
		do {
			int res;
			if(int.TryParse(Console.ReadLine(), out res)) {
				return res;
			}
			Console.WriteLine("Ошибка. Введите ещё раз: ");
		} while(true);
	}

	static void Main(string[] args) {
		Console.Write("Введите A: ");
		var a = readInt();
		Console.Write("Введите B: ");
		var b = readInt();

		if(a > b) {
			Console.WriteLine("Неправильный диапазон");
			return;
		}

		Console.WriteLine("Цикл for:");
		for(int i = a; i <= b; i++) {
			if(i % 2 == 0 & i % 3 == 0) {
				Console.Write(i + " ");
			}
		}
		Console.WriteLine();

		Console.WriteLine("Цикл do while:");
		{
			int i = a;
			do {
				if(i > b) break;
				if(i % 2 == 0 & i % 3 == 0) {
					Console.Write(i + " ");
				}
				i++;
			} while(true);
			Console.WriteLine();
		}

		Console.WriteLine("Цикл while:");
		{
			int i = a;
			while(i <= b) {
				if(i % 2 == 0 & i % 3 == 0) {
					Console.Write(i + " ");
				}
				i++;
			}
			Console.WriteLine();
		}
	}
}