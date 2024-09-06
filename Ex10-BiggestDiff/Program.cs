Console.WriteLine(BiggestDifference(new int[]{10, 7, 20, 19}));

int BiggestDifference(int[] numbers)
{
    var biggestDiff = 0;
    
    for (int i = 0; i < numbers.Length; i++)
    {
        for (int j = 0; j < numbers.Length; j++)
        {
            if (i == j)
            {
                continue;
            }

            biggestDiff = int.Max(biggestDiff, Math.Abs(numbers[i] - numbers[j]));
        }
    }

    return biggestDiff;
}