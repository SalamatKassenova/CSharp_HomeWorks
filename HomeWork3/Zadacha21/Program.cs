double[] x = new double[3];

for (int i = 0; i < 3; i++)
{
    Console.WriteLine("Enter {0} of 3 coordinate of x : ", i + 1);
    x[i] = Convert.ToDouble(Console.ReadLine());
}

double[] y = new double[3];

for (int i = 0; i < 3; i++)
{
    Console.WriteLine("Enter {0} of 3 coordinate of y : ", i + 1);
    y[i] = Convert.ToDouble(Console.ReadLine());
}

Console.WriteLine(Distance(x,y));

float Distance (double[] x, double[] y)
{
    float distance=(float) Math.Sqrt(Math.Pow(x[0]-y[0],2) + 
Math.Pow(x[1]-y[1],2) + Math.Pow(x[2]-y[2],2));
    float rounded = (float)(Math.Round((double)distance, 2));
    return rounded;
}

