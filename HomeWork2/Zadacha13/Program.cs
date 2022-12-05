//13
Console.WriteLine("Введите целое число");
int a = Convert.ToInt32(Console.ReadLine()); //1234
int m = 0;

if (a>99){
    while (a>99)
    {
        if (a<1000)
        {
            m=a%10;
            Console.WriteLine(m);
        }

    a = a/10;
}
}
else
{
    Console.WriteLine("третьей цифры нет");
}

