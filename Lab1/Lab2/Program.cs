using System;
class Program {
	static void Main(string[] args) {
		Console.Write("Введите 3-х значное число: ");
		do {
			int res;
			var str = Console.ReadLine();
			if(int.TryParse(str, out res)
				&& (res > 0 ? str.Length == 3 : str.Length == 4)
			) {
				int offset = res > 0 ? 0 : 1;
				var secondDigit = str[offset + 1] - '0';
				var lastDigit = str[offset + 2] - '0';
				if(secondDigit > lastDigit) {
					Console.WriteLine("Вторая цифра больше последней");
				}
				else if(secondDigit < lastDigit) {
					Console.WriteLine("Вторая цифра меньше последней");
				}
				else Console.WriteLine("Вторая цифра равна последней");

				return;
			}
			Console.Write("Ошибка. Введите ещё раз: ");
		} while(true);
	}
}

