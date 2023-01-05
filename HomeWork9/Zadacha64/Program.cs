Console.WriteLine("Введите наутральное число n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(PrintNumbers(n));

string PrintNumbers(int n)
{
    if (n == 1) return n.ToString();
    else return (n + ", " + PrintNumbers(n-1));
}
