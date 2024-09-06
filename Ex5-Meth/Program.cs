using Ex5_Meth.MathLib;

Calculator calculator = new Calculator();

Console.WriteLine(calculator.Add(2, 5));
Console.WriteLine(calculator.Add(new int[] {1, 2, 3, 4, 5}));
Console.WriteLine(calculator.MaxOfTwo());