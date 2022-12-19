Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количесвто столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
double[,] numbers = new double[rows, cols];
FillArray(numbers);
PrintArray(numbers);

void FillArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = Convert.ToDouble(new Random().Next(-100,100))/10;
        }
    }
}
void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(Math.Round(array[i,j], 1) + " " );
        }
    }
    Console.WriteLine(" ");
}