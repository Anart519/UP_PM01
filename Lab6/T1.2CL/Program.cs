using System;
using System.Collections.Generic;

class Program {    
    static int [,] Input(out int n, out int m) {
        Console.WriteLine("введите размерность массива");
        Console.Write("n = ");
        n=int.Parse(Console.ReadLine());
        Console.Write("m = ");
        m=int.Parse(Console.ReadLine());
		if(n <= 0 || m <= 0) {
			throw new InvalidOperationException("Неправильный размер массива");
		}
        int [,]a=new int[n, m];
        for (int i = 0; i < n; ++i) 
        for (int j = 0; j < m; ++j){
			Console.Write("a[{0},{1}]= ", i, j);
			a[i, j]=int.Parse(Console.ReadLine());
        }
        return a;
    }
    
    static void Print(int[,] a) {
		for (int i = 0; i < a.GetLength(0); ++i, Console.WriteLine())
		for (int j = 0; j < a.GetLength(1); ++j)
			Console.Write("{0,5} ", a[i, j]);
    }
    
    static int[][] notDivisibleBy7(int[,] a) {
		var res = new List<int[]>();
		for(int i = 0; i < a.GetLength(0); ++i)
        for(int j = 0; j < a.GetLength(1); ++j) {
			if(a[i, j] % 7 != 0) {
				res.Add(new[]{i, j});
			}
		}
		return res.ToArray();
    }
    
    static void Main() {
		try{
		int n,m;
		int[,] myArray=Input(out n, out m);
		Console.WriteLine("Исходный массив:");
		Print(myArray);
		var newArr = notDivisibleBy7(myArray);
		Console.WriteLine("На 7 не делятся {0} элемент(-ов):", newArr.Length);
		for(int i = 0; i < newArr.Length; i++) {
			Console.WriteLine("({0}; {1})", newArr[i][0], newArr[i][1]);
		}
		} catch(Exception e){ Console.WriteLine(e.Message); }
    }
}

