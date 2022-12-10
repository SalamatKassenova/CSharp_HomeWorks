Console.WriteLine("Введите целое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите в какую степень");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(PowerOf(num1));

int PowerOf(int num1)
{
    int res = num1;
    while (num2 > 1)
    {
        res = res*num1;
        num2--;
    }
    return res;
}
