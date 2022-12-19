int[,] numbers = new int[4, 4];
FillArray(numbers);
PrintArray(numbers);
Find(numbers);

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToInt32(new Random().Next(1, 10));
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write((array[i, j]) + " ");
        }
    }
    Console.WriteLine(" ");
}

void Find(int[,] array)
{
    double mean = 00.00; 
    string res = "";
    for (int i = 0; i < array.GetLength(0); i++)
    {   
        
        for (int j = 0; j < array.GetLength(1); j++)
        {
            mean += array[i,j]; 
        }
        res += $"{mean/4}" + "; ";
        mean = 00.00;
    }
    Console.WriteLine("Среднее арифметическое каждого столбца: " + res);
}
