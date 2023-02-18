Console.Clear();

Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцoв: ");
int columns = int.Parse(Console.ReadLine());

Double[,] GetArray(int m, int n)
{
    Double[,] result = new Double[m,n];
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            result[i,j] = new Random().NextDouble()*(9);
        }
    }
    return result;
}
Double[,] array = GetArray(rows, columns);
void PrintArray(Double[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]:f1} ");
        }
        Console.WriteLine();
    }
}
PrintArray(array);

