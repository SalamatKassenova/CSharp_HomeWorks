Console.WriteLine("Введите размер массива");
int count = Convert.ToInt32(Console.ReadLine());

//создание массива с рандомными числами от 0 до 100
int[] intArray = new int[count];
Random rand = new Random();
for (int i = 0; i < intArray.Length; i++)
   intArray[i] = rand.Next(0, 100);
Console.WriteLine(String.Join(" ", intArray)); 

//Сортировка от максимального значения к минимального, без встроенных методов Array
int temp = 0;

for (int i = 0; i <= intArray.Length - 1; i++)
{
    for (int j = i + 1; j < intArray.Length; j++)
    {
        if (intArray[i] < intArray[j])
        {
            temp = intArray[i];
            intArray[i] = intArray[j];
            intArray[j] = temp;
        }
    }
}
Console.WriteLine(String.Join(" ", intArray));

// Перемешиваем имеющиеся значения по методу тасования Фишера — Йетса
static void ShaffleArray(int[] intArray, int count)
{
    Random random = new Random();
    for (int i = intArray.Length - 1; i > 0; i--)
    {       
        int randomIndex = random.Next(0, i + 1);    
        int temp = intArray[i];
        intArray[i] = intArray[randomIndex];
        intArray[randomIndex] = temp;
    }
    Console.WriteLine(string.Join(" ", intArray));
}

ShaffleArray(intArray, count);