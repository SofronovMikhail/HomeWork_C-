Console.Clear();
Console.Write("Введите min значение массива: ");
int min = int.Parse(Console.ReadLine());
Console.Write("Введите max значение массива: ");
int max = int.Parse(Console.ReadLine());
int[] Array(int min1, int max1)
{
    int length = 8;
    int[] array1 = new int[length];
    for(int i = 0; i < length; i++)
    {
        array1[i] = new Random().Next(min1, max1);
    }
    return array1;
}
int[] array2 = Array(min, max);
Console.WriteLine($"[{String.Join(", ", array2)}]");

