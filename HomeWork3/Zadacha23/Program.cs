Console.WriteLine("Введите целое положительное число");
int a = Convert.ToInt32(Console.ReadLine());
PowerOf(a);

void PowerOf(int a)
{
    int res = 0;
    for (int i=1; i<=a; i++)
    {
        res =  i*i*i;
        Console.WriteLine(res);
    }
}
