Console.WriteLine("Введите целое или дробное число");
string num = Convert.ToString(Console.ReadLine());
Console.WriteLine(CountNum(num));

int CountNum(string num)
{
    int count = num.Count(c  => Char.IsNumber(c));
    return count;
}
