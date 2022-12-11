double[] array = new double[4];
Random random = new Random();
for (int i = 0; i < 4; i++)
    array[i] = Math.Round(random.NextDouble() * 10, 3);;
Console.WriteLine(String.Join(" ", array));

double SubstractMinFromMax(double[] array)
{
    double max = array[0];
    double min = array[0];
    
    for (int i = 0; i < 4; i++)
    {
        if (max < array[i])
        {
            max = array[i];
        }
    }
    for (int i = 0; i < 4; i++)
    {
        if (min > array[i])
        {
            min = array[i];
        }
    }
    
    return Math.Round((max - min), 3);
}

Console.WriteLine(SubstractMinFromMax(array));
