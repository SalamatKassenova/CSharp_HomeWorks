int[] array = new int[4];
Random rand = new Random();
for (int i = 0; i < 4; i++)
    array[i] = rand.Next(-10, 100);
Console.WriteLine(String.Join(" ", array));

int SumOdd(int[] array)
{
    int sum = 0;

    for (int i = 0; i < 4; i++)
    {
        if (i%2 != 0)
        {
            sum = sum + array[i];
        }
    }
    return sum;
}

Console.WriteLine(SumOdd(array));
