// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.WriteLine("Введите число строк матрицы: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов матрицы: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное число в матрице");
int range = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];
CreateArray(array);
PrintArray(array);

int minSumLine = 0;
int sumLine = MinElement(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
    int tempSumLine = MinElement(array, i);
    if (sumLine > tempSumLine)
    {
        sumLine = tempSumLine;
        minSumLine = i;
    }
}
Console.WriteLine();
Console.WriteLine($"{minSumLine + 1} - строка с наименьшей суммой: ({sumLine +1 })");

int MinElement(int[,] array, int i)
{
    int sumLine = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sumLine += array[i, j];
    }
    return sumLine;
}

void CreateArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(range);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}




