int[] Array1 = new int[8];
for (int i = 0; i < Array1.Length; i++)
{
    Console.WriteLine("Напишите " + (i + 1) + " элемент массива:");
    Array1[i] = Convert.ToInt32(Console.ReadLine());

}
for (int i = 0; i < Array1.Length; i++)
{
    Console.Write(Array1[i] + " ");
}
Console.ReadKey();