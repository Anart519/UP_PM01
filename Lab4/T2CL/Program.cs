using System;

class Program {
	static void print(int n, int row = 1) {
		var cols = row * 2 - 1;
		if(cols < n) {
			for (int i = 0; i < n /2- cols/2; i++) Console.Write(" ");
			for (int i = 0; i < cols; i++) Console.Write(row);
			Console.WriteLine("");
			print(n, row+1);
			for (int i = 0; i < n /2- cols/2; i++) Console.Write(" ");
			for (int i = 0; i < cols; i++) Console.Write(row);
			Console.WriteLine("");
		}
		else {
			for (int i = 0; i < n; i++) Console.Write(row);
			Console.WriteLine("");
		}
    }
	static void Main(string[] args) {
		Console.Write("Введите n: ");
		int n;
		do { 
			if(int.TryParse(Console.ReadLine(), out n) && n > 0) break;
			Console.Write("Ошибка. Введите ещё раз: ");
		} while(true);
		print(n);
	}
}