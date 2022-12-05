//10
Console.WriteLine("Введите целое число");
int a = Convert.ToInt32(Console.ReadLine()); 
int m = 0;

if (a>9){
    while (a>9)
    {
        if (a<100)
        {
            m=a%10;
            Console.WriteLine(m);
        }

    a = a/10;
}
}
