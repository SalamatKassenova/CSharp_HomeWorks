Console.WriteLine("Введите целое число");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(CountSum(num));

int CountSum(int num)
{
    int res = 0;
    while (num>0)
    {
        res = res + num%10;
        num = num/10;
    }
    return res;
}