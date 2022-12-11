Random rand = new Random();
int count = rand.Next(8,11);
List<int> array = new List<int>();
int number;
for (int i = 0; i < count; i++)
{
  do {
     number = rand.Next(1, 13);
  } while (array.Contains(number));
  array.Add(number);
}

Console.WriteLine(string.Join(", ", array));

//find min value
int min = array[0];
int[] array2 = new int[];
for (int i = 0; i < count; i++)
{
    if (min > array[i])
    {
        min = array[i];
        
    }
}

// int[] Append(int[] array, int item)
// {
//     int max = array[0];
//     //int[] array2 = new int[];
//     for (int i = 0; i < count; i++)
//     {
//         if (min > array[i])
//         {
//             min = array[i];
//         }
//     }
//     if (array2 == null)
//     {
//         return new int[] { min };
//     }
//     int[] result = new int[array2.Length + 1];
//     array2.CopyTo(result, 0);
//     result[array2.Length] = item;
//     return result;
// }

// Console.WriteLine(Append(array));

//найти мин
// 1)если мин и мин+1 есть в массив1, записать в массив2 и тд (цикл)
// 2)если мин+1 нет, создать темп массив без мин, найти след мин и повторить пункт 1 (цикл)
// 3) сравнить массив 2 и темп массив без эдементов массива 2:
//  - если массив 2 больше - ретерн массив 2
//  - если массив 2 меньше - найти мин в темп массив (в котором нет элементов массива 2) и повторить 1 пункт, только вместо массива2 в массив3 записывать.
//  4) удалять числа с темп массива, после каждого цикла создания новых массивов, до тех пор пока темп массив не станет меньше одного из полученных массивов
//  5) ретерн мин и макс элемент массива с наибольшей длинной 