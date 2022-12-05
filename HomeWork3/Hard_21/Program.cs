Console.WriteLine("Введите число, для n-мерного пространства");
int n = Convert.ToInt32(Console.ReadLine());

double[] x = new double[n];

for (int i = 0; i < n; i++)
{
    Console.WriteLine("Enter {0} of n coordinate of x : ", i + 1);
    x[i] = Convert.ToDouble(Console.ReadLine());
}

double[] y = new double[3];

for (int i = 0; i < n; i++)
{
    Console.WriteLine("Enter {0} of n coordinate of y : ", i + 1);
    y[i] = Convert.ToDouble(Console.ReadLine());
}
    
    
if (n==2)
{
    float distance=(float) Math.Sqrt(Math.Pow(x[0]-y[0],2) + Math.Pow(x[1]-y[1],2));
    float rounded = (float)(Math.Round((double)distance, 2));
    Console.WriteLine(rounded);
}
else if (n==3)
{
    float distance=(float) Math.Sqrt(Math.Pow(x[0]-y[0],2) + Math.Pow(x[1]-y[1],2) + Math.Pow(x[2]-y[2],2));
    float rounded = (float)(Math.Round((double)distance, 2));
    Console.WriteLine(rounded);       
}



