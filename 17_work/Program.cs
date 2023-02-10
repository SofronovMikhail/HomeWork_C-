Console.Clear();
Console.WriteLine("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());
Console.WriteLine("Введите минимальное число массива: ");
int min = int.Parse(Console.ReadLine());
Console.WriteLine("Введите максимальное число массива: ");
int max = int.Parse(Console.ReadLine());
int[] Array(int size1)
{
    int[] arr = new int[size1];
    for(int i = 0; i < size1; i++)
    {
        arr[i] = new Random().Next(min, max + 1);
    }
    return arr;
}
int[] array = Array(size);
Console.WriteLine($"[{String.Join(", ", array)}]");
int Sum(int[] mas)
{
    int sum = 0;
    for(int i =1; i < mas.Length; i++)
    {
        if(i %2 != 0)
        {
            sum += mas[i];
        }
    }
    return sum;
}
Console.WriteLine(Sum(array));
