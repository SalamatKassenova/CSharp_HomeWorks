//8
Console.WriteLine("Введите целое число");
int a = Convert.ToInt32(Console.ReadLine());
string res = "";
while (a > 1)
{
    if (a%2 == 0){
        res = Convert.ToString(a) + "," + res;
        a--;
    }
    else {
        a--;
    }
}
res = res.TrimEnd(',');
Console.WriteLine(res);
