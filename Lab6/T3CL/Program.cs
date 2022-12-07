using System;

class Program {
	static int readInt() {
		int res;
		while(!int.TryParse(Console.ReadLine(), out res))
			Console.Write("Ошибка. Введите ещё раз: ");
		return res;
	}

	static void Main(string[] args) {
		Console.Write("Введите m: ");
		var m = readInt();
		Console.Write("Введите k: ");
		var k = readInt();
		if(m <= 0 || k <= 0) {
			Console.WriteLine("Неправильные размеры массива");
			return;
		}

		var mat = new int[m, k];

		int num = 0;
		for(int i = 0; i < k; i++)
		for(int j = 0; j < m; j++) {
			int col;
			if(i % 2 == 0) col = j;
			else col = m-1 - j;
			mat[col, i] = num++;
		}

		for(int i = 0; i < m; i++, Console.WriteLine())
		for(int j = 0; j < k; j++) 
			Console.Write("{0}\t", mat[i, j]);
	}
}

