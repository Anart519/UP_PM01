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
		var n = readInt();
		if(n <= 0) {
			Console.WriteLine("Неправильные размеры массива");
			return;
		}

		var mat = new int[n, n];
        
		for(int i = 0; i < n; i++)
		for(int j = 0; j < n; j++) {
            Console.Write("mat[{0}, {1}] = ", i, j);
            mat[i, j] = readInt();
		}

		Console.WriteLine("Матрица: ");
		for(int i = 0; i < n; i++, Console.WriteLine())
		for(int j = 0; j < n; j++) {
            Console.Write("{0} ", mat[i, j]);
		}

		bool symmetric = true;
		for(int i = 0; i < n; i++)
		for(int j = i+1; j < n; j++) {
			if(mat[i, j] != mat[j, i]) {
				symmetric = false;
				break;
			}
		}

		Console.WriteLine(
			"Матрица {0}симметрична относительно главной диагонали", 
			symmetric ? "" : "не"
		);
	}
}

