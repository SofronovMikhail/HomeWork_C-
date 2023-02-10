Console.Clear();
Console.WriteLine("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());
int[] Array(int size1)
{
    int[] arr = new int[size1];
    for(int i = 0; i < size1; i++)
    {
        arr[i] = new Random().Next(100, 1000);
    }
    return arr;
}
int[] array = Array(size);
Console.WriteLine($"[{String.Join(", ", array)}]");
int Count(int[] mas)
{
    int count = 0;
    foreach (var item in mas)
    {
        if(item %2 == 0)
        {
            count++;
        }
    }
    return count;
}
Console.WriteLine(Count(array));
