PrintEven(69);
PrintOdd(69);
PrintDivisibleByY(69, 10);

void PrintEven(int x)
{
    for (var i = 0; i <= x; i += 2)
    {
        Console.WriteLine(i);
    }
}

void PrintOdd(int x)
{
    for (var i = 1; i <= x; i += 2)
    {
        Console.WriteLine(i);
    }
}

void PrintDivisibleByY(int x, int y)
{
    for (int i = y; i <= x; i += y)
    {
        Console.WriteLine(i);
    }
}