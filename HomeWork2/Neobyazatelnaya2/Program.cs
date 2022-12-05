Console.WriteLine("Введите целое положительное число");
int a = Convert.ToInt32(Console.ReadLine());
if (a%10 == 1 && a %100 != 11)
{
    Console.WriteLine($"{a} программист");
    return;
}
if (a%10 == 2 && a%100 != 12 || a%10 == 3 && a%100 != 13  || a%10 == 4 && a%100 != 14)
{
    Console.WriteLine($"{a} программистa");
    return;
}
else {
    Console.WriteLine($"{a} программистов");

}