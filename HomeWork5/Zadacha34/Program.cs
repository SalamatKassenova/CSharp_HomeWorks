int[] array = new int[4];
Random rand = new Random();
for (int i = 0; i < 4; i++)
    array[i] = rand.Next(100, 999);
Console.WriteLine(String.Join(" ", array));

int CountEven(int[] array)
{
    int count = 0;

    for (int i = 0; i < 4; i++)
    {
        if (array[i]%2 == 0)
        {
            count++;
        }
    }
    return count;
}

Console.WriteLine(CountEven(array));