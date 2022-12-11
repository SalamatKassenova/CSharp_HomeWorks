Random random = new Random();
int count = random.Next(4,10);
int[] array = new int[count];
for (int i = 0; i < count; i++)
    array[i] = random.Next(10, 100);;
Console.WriteLine(String.Join(" ", array));

void MaxMin(int[] array)
{
    int max = array[0];
    int min = array[0];
    int maxIndex = 0;
    int minIndex = 0;
    int mean = 0;
        
    for (int i = 0; i < count; i++)
    {
        if (max < array[i])
        {
            max = array[i];
            maxIndex = i;
        }
    }
    for (int i = 0; i < count; i++)
    {
        if (min > array[i])
        {
            min = array[i];
            minIndex = i;
        }
    }

    for (int i = 0; i < count; i++)
    {
        mean = mean + array[i];
    }

    Dictionary<string, int> finalArray = new Dictionary<string, int>();
    {
        finalArray["Максимальное значение"] = max;
        finalArray["Индекс макисмального значения"] = maxIndex;
        finalArray["Минимальное значение"] = min;
        finalArray["Индекс минимального значения"] = minIndex;
    }

    foreach (var pair in finalArray)
    {
        Console.WriteLine("{0},{1}", pair.Key, String.Join(" ", pair.Value));
    }
    Console.ReadKey();    
}

MaxMin(array);
  
int Median(int[] array)
{
    int median = 0;    
    int temp = 0;

    for (int i = 0; i <= array.Length - 1; i++)
    {
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[i] < array[j])
            {
                temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }
    }
 
    if (array.Length%2 == 0)
    {
        for (int i = 0; i < array.Length; i++)
        {
            median = (array[array.Length/2-1] + array[array.Length/2])/2;
        }
    }
    else 
    {
        median = (array[array.Length/2]);
    }    

    return median;
}  
  
 Console.WriteLine($"Медиана: {Median(array)}");
  
  
  
  
   

