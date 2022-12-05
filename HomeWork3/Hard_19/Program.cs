Console.WriteLine("Введите n-значное число");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(CheckPalindrome(number));

string CheckPalindrome(int number) 
{
    string res;
    int digits;
    int reverse = 0;
    int num = number;
    while (num > 0) //12321
    {
        digits = num%10; //1 //2 // 3 //2 //1
        reverse = reverse * 10 + digits; //1 //12 //123 //1232 //12321
        num = num/10; //1232 // 123 //12 //1 
    }
    if (number == reverse) res = "да"; 
    else res = "нет";
    return res;

}
