//FIZZ BUZZ
int number = 1;
string res = "";
for (int i=0; i<100; i++)
{
    if (number%3 != 0 && number%5 != 0)
    {
        res = res + " " + Convert.ToString(number);
    }
    if (number%3 == 0 && number%5 == 0)
    {
        res = res + " FizzBuzz";
    }
    if (number%3 == 0 && number%5 != 0)
    {
        res = res + " Fizz";
    }
    if (number%3 != 0 && number%5 == 0)
    {
        res = res + " Buzz";
    }    
    
    number++;
}
res = res.TrimStart(' ');
Console.WriteLine(res);
