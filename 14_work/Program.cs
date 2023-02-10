Console.Clear();
Console.WriteLine("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());
Console.WriteLine("Введите минимальное число массива: ");
int min = int.Parse(Console.ReadLine());
Console.WriteLine("Введите максимальное число массива: ");
int max = int.Parse(Console.ReadLine());

int[] Mas(int size1, int min1, int max1)
{
    int[] arr = new int[size1];
    for(int i = 0; i < size1; i++)
    {
        arr[i] = new Random().Next(min1, max1 + 1);
    }
    return arr;
}
int[] array1 = Mas(size, min, max);
Console.WriteLine($"[{String.Join(", ", array1)}]");

int Count(int[] array)
{
    int count = 0;
    foreach(int el in array)
    {
        if(el > 9 && el <100)
        {
            count++;
        }
    }
    return count;
}
Console.WriteLine(Count(array1));

