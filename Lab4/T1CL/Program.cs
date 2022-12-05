using System;

class Program {
	private static uint akkerman(uint n, uint m) {
		if(n == 0) return m + 1;
		else if(m == 0) return akkerman(n-1, 1);
		else return akkerman(n-1, akkerman(n, m-1));
	}

	private static uint readUint() {
		do {
			uint res;
			if(uint.TryParse(Console.ReadLine(), out res))
				return res;
			Console.WriteLine("Ошибка. Введите ещё раз: ");
		} while(true);
	}
	static void Main(string[] args) {
		Console.Write("Введите n: ");
		var n = readUint();
		Console.Write("Введите m: ");
		var m = readUint();

		Console.WriteLine("Результат: {0}", akkerman(n, m));
	}
}