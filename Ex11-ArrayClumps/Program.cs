Console.WriteLine(CountClumps(new int[]{1, 1, 2, 1, 1}));

int CountClumps(int[] array)
{
    if (array.Length < 2)
    {
        return 0;
    }
    
    int clumps = 0;
    int previous = array[0];
    bool middleOfAClump = false;

    for (int i = 1; i < array.Length; i++)
    {
        if (previous == array[i])
        {
            if (!middleOfAClump)
            {
                clumps++;
                middleOfAClump = true;
            }
        }
        else
        {
            middleOfAClump = false;
        }

        previous = array[i];
    }
    
    return clumps;
}