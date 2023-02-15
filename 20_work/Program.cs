Console.Clear();
Console.Write("Введите числа через пробел: ");
string st = Console.ReadLine();
int[]Arr(string st1)
{
string[] arr = st1.Split(" ", StringSplitOptions.RemoveEmptyEntries);
int[] array = new int[arr.Length];
for(int i = 0; i < array.Length; i++)
{
    array[i] = int.Parse(arr[i]);
}
return array;
}
int[] array = Arr(st);

int Count(int[] arr1)
{  
    int count = 0;
    foreach(int i in arr1)
    {
        if(i > 0)
        {
            count++;
        }
    }
    return count;
}
int count = Count(array);
Console.WriteLine(count);

