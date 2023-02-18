Console.Clear();

Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцoв: ");
int columns = int.Parse(Console.ReadLine());

Console.Write("Введите минимальное значение элементов массива: ");
int min = int.Parse(Console.ReadLine());

Console.Write("Введите максимальное значение элемента массива: ");
int max = int.Parse(Console.ReadLine());

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m,n];
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            result[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}
int[,] array = GetArray(rows, columns, min, max);

Double[] Sum(int[,] array1)
{
    Double[] arr1 = new Double[array1.GetLength(1)];
    
    for(int i = 0; i < array1.GetLength(1); i++)
    {
        Double sum = 0;
        for(int j = 0; j < array1.GetLength(0); j++)
        {
            sum += array1[j, i]; 
        }
        arr1[i] = sum/array1.GetLength(0);
    }
    return arr1;
}
Double[] sum = Sum(array);

void PrintArray(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}
PrintArray(array);
Console.WriteLine($"Среднее арифметическое каждого столбца: [{String.Join("; ", sum)}]");


