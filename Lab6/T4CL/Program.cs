using System;

class Program {

	static int readInt() {
		int res;
		while(!int.TryParse(Console.ReadLine(), out res))
			Console.Write("Ошибка. Введите ещё раз: ");
		return res;
	}

	static void Main(string[] args) {
		Console.Write("Введите n: ");
		int n = readInt();
		if(n <= 0) {
			Console.WriteLine("Неправильные размеры мессива");
			return;
		}

		Console.Write("Введите k1: ");
		int k1 = readInt();
		if(k1 < 0 || k1 >= n) {
			Console.WriteLine("Неправильный номер k1");
			return;
		}
		Console.Write("Введите k2: ");
		int k2 = readInt();
		if(k2 < 0 || k2 >= n || k2 < k1) {
			Console.WriteLine("Неправильный номер k2");
			return;
		}

		var arr = new int[n][];

		for(int i = 0; i < n; i++) {
			arr[i] = new int[n];

			for(int j = 0; j < n; j++) {
				Console.Write("a[{0}][{1}] = ", i, j);
				arr[i][j] = readInt();
			}
		}

		var prods = new int[n];
		for(int j = 0; j < n; j++) {
			int prod = 1;
			for(int i = k1; i <= k2; i++) {
				prod *= arr[i][j];
			}
			prods[j] = prod;
		}

		Console.WriteLine("Исходный массив: ");
		for(int i = 0; i < n; i++, Console.WriteLine())
		for(int j = 0; j < n; j++) {
			Console.Write("{0,5}", arr[i][j]);
		}

		Console.WriteLine("Произмедения столбцов от [{0}] до [{1}]: ", k1, k2);
		for(int i = 0; i < n; i++) {
			Console.Write("{0} ", prods[i]);
		}
		Console.WriteLine();
	}
}

