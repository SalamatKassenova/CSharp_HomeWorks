Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(CheckPalindrome(number));

string CheckPalindrome(int number) 
{
    string res;
    int temp = number/1000;
    int temp2 = number/10;
    if (number/10000 == number%10 && temp%10 == temp2%10) res = "да";
    else res = "нет";
    return res;

}