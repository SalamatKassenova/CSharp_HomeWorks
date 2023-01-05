Console.WriteLine("Введите наутральное число от которого начнется отсчет: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите наутральное число до кторого будет отсчет: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(PrintNumbers(m, n));

int PrintNumbers(int m, int n)
{
    if (n == m) return m;
    else return (n + PrintNumbers(m, n-1));
}
