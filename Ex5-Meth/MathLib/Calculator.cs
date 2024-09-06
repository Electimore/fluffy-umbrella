namespace Ex5_Meth.MathLib;

public class Calculator
{
    public int Add(int x, int y)
    {
        return x + y;
    }

    public int Add(int[] numbers)
    {
        var x = 0;
        
        foreach (var number in numbers)
        {
            x += number;
        }

        return x;
    }

    public int MaxOfTwo()
    {
        int x = Int32.Parse(Console.ReadLine());
        int y = Int32.Parse(Console.ReadLine());
        if (x > y)
        {
            return x;
        }
        else
        {
            return y;
        }
    }
}