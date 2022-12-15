Console.WriteLine("Введите целые числа через пробел");
int[] str = Console.ReadLine().Split().Select(int.Parse).ToArray();
Positive(str);

void Positive(int[] str)
{   
    int count = 0;
    for (int i = 0; i < str.Length; i++)
    {
        if (str[i]>0)
        {
            count++;
        }
    }
    Console.WriteLine(count);
}
