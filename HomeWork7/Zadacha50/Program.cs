int[,] numbers = new int[4, 4];
FillArray(numbers);
PrintArray(numbers);
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
Find(numbers, num);

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

void Find(int[,] array, int num)
{
    string res = "";
    for (int i = 0; i < array.GetLength(0); i++)
    {        
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == num)
            {
                res = $"строка {i + 1} ";
                Console.Write(res);
                res = $" столбец {j + 1}";
                Console.Write(res);
                Console.WriteLine();
            }
        }
    }
    if (res == "")
    {
        Console.WriteLine("такого числа в массиве нет");
    }

}