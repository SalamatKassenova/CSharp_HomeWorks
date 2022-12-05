//4
Console.WriteLine("Введите первое целое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье целое число");
int c = Convert.ToInt32(Console.ReadLine());
if (a>b && a>c)  
{
    Console.WriteLine(a);
}
if (c>b && c>a)  
{
    Console.WriteLine(c);
}
else 
{
    Console.WriteLine(b);
}
