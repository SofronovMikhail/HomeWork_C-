Console.Clear();
Console.WriteLine("Введите через пробел значения массива: ");
string num = Console.ReadLine();
Double[] Array(string num1)
{
    string[] arr = num1.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    Double[] mas = new Double[arr.Length];
    for(int i = 0; i < arr.Length; i++)
    {
        mas[i] = Double.Parse(arr[i]);
    }
    return mas;
}
Double[] array = Array(num);
Console.WriteLine($"[{String.Join(" ", array)}]");
Double Sum(Double[] array1)
{
    int i = 0;
    Double min = array1[i];
    Double max = array1[i]; 
    for(; i < array1.Length; i++)
    { 
        if(array1[i] < min)
        {
          min = array1[i];
        }
       
        if(array1[i] > max)
        {
          max = array1[i];
        }
    }
    Double sum = max - min;
    return sum;
}
Console.WriteLine(Sum(array));