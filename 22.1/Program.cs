Console.Clear();

Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцoв: ");
int columns = int.Parse(Console.ReadLine());

Console.Write("Введите позицию в строке: ");
int row = int.Parse(Console.ReadLine());

Console.Write("Введите позицию в столбце: ");
int col = int.Parse(Console.ReadLine());

int[,] GetArray(int m, int n)
{
int[,] result = new int[m,n];
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            Console.Write($"Введите элемент массива [{i},{j}]: ");
            result[i,j] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine();
    }
    return result;
}
int[,] array = GetArray(rows, columns);

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
        Console.WriteLine($"Выбранное число: {arr[row1, col1]}");
    }
    else{
        Console.WriteLine("Такого числа нет");
    }
}
PrintArray(array);
Print(array, row, col);
