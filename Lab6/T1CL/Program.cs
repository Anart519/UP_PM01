using System;
using System.Collections.Generic;

class Program {
    static int [] Input () {
        Console.Write("введите размер массива: ");
        int n=int.Parse(Console.ReadLine());
		if(n <= 0) { 
			Console.WriteLine("Неправильный размер массива");
			throw new InvalidOperationException();
		}
        int[] a = new int[n];
        for(int i = 0; i < n; ++i) {
            Console.Write("a[{0}] = ", i);
            a[i] = int.Parse(Console.ReadLine());
        }
        return a;
    }

    static void Print(int[] a) {
        for (int i = 0; i < a.Length; ++i) Console.Write("{0} ", a[i]);
        Console.WriteLine();
    }

    static int[] notDivisibleBy7(int[] a) {
        var res = new List<int>();
        for(int i = 0; i < a.Length; ++i)
            if(a[i] % 7 != 0) res.Add(i);
        return res.ToArray();
    }

    static void Main() {
        int[] myArray=Input();
        Console.WriteLine("Исходный массив:");
        Print(myArray);
        var newArr = notDivisibleBy7(myArray);
        Console.WriteLine("Индексы элементов, не делящихся на 7:");
        Print(newArr);
    }
}
