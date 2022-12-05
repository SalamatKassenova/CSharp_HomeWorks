//2
Console.WriteLine("Введите целое число a");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое число b");
int b = Convert.ToInt32(Console.ReadLine());
if (a>b)
{
    Console.WriteLine($"max = {a}");
}
else 
{
    Console.WriteLine($"max = {b}");
}
