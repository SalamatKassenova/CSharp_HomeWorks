// Задайте двумерный массив из целых чисел. Количество строк и столбцов задается с клавиатуры. Отсортировать элементы по возрастанию слева направо и сверху вниз.

// Например, задан массив:
// 1 4 7 2
// 5 9 10 3

// После сортировки
// 1 2 3 4
// 5 7 9 10

Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количесвто столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[rows, cols];
FillArray(numbers);
PrintArray(numbers);
Sort(numbers);

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = Convert.ToInt32(new Random().Next(0,10));
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
            Console.Write((array[i,j]) + " " );
        }
    }
    Console.WriteLine(" ");
}

void Sort(int[,] array)
{
    int[,] temp = new int[1,4];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j]>array[i+1, j+1])
            {
                temp = array[i,j];
                array[i+1, j+1] = array[i,j];
                temp = array[i+1,j+1];
            }
        }
        Console.WriteLine(array);
    }
    
}