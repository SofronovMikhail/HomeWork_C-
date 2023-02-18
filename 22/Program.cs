Console.Clear();

Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцoв: ");
int columns = int.Parse(Console.ReadLine());

Console.Write("Введите минимальное значение элементов массива: ");
int min = int.Parse(Console.ReadLine());

Console.Write("Введите максимальное значение элемента массива: ");
int max = int.Parse(Console.ReadLine());

Console.Write("Введите позицию в строке: ");
int row = int.Parse(Console.ReadLine());

Console.Write("Введите позицию в столбце: ");
int col = int.Parse(Console.ReadLine());

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
int[,] result = new int[m,n];
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            result[i,j] = new Random().Next(minValue, maxValue + 1);
        }
        Console.WriteLine();
    }
    return result;
}
int[,] array = GetArray(rows, columns, min, max);

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

void Print(int[,] arr, int row1, int col1)
{
    if(row1 < arr.GetLength(0) || col1 < arr.GetLength(1))
    {
        Console.WriteLine($"{arr[row1, col1]}");
    }
    else{
        Console.WriteLine("Такого числа нет");
    }
}
PrintArray(array);
Print(array, row, col);

