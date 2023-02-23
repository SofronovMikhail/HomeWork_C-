Console.Clear();

Console.Write("Введите количество строк 1 матрицы: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцoв 1 матрицы: ");
int columns = int.Parse(Console.ReadLine());

Console.Write("Введите минимальное значение элементов массива 1 матрицы: ");
int min = int.Parse(Console.ReadLine());

Console.Write("Введите максимальное значение элемента массива 1 матрицы: ");
int max = int.Parse(Console.ReadLine());

int[,] GetArray1(int m, int n, int minValue, int maxValue)
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
int[,] array = GetArray1(rows, columns, min, max);

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
Console.WriteLine();

Console.Write("Введите количество строк 2 матрицы: ");
int rows2 = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцoв 2 матрицы: ");
int columns2 = int.Parse(Console.ReadLine());

Console.Write("Введите минимальное значение элементов массива 2 матрицы: ");
int min2 = int.Parse(Console.ReadLine());

Console.Write("Введите максимальное значение элемента массива 2 матрицы: ");
int max2 = int.Parse(Console.ReadLine());

int[,] array2 = GetArray1(rows2, columns2, min2, max2);
PrintArray(array2);
Console.WriteLine();

if(rows != columns2)
{
    Console.WriteLine("Массив не может быть перемножен.");
    return;
}

int[,] MultiplicationArray(int[,] mass1, int[,] mass2)
{
    int[,]multArray = new int[mass1.GetLength(0), mass2.GetLength(1)];
    int[]arr = new int[mass1.GetLength(1)];
     for(int i = 0; i < multArray.GetLength(0); i++)
    {   
       
        for(int j = 0; j <mass1.GetLength(0); j++)
        { 
            int sum = 0;
            for(int k = 0; k < mass1.GetLength(1); k++)
            {
                arr[k] = mass1[j,k] * mass2[k,i];
                sum += arr[k];
            }
            multArray[j,i] = sum;
        }
          
    }
    return  multArray;  
}
int [,] result = MultiplicationArray(array, array2);
PrintArray(result);
Console.WriteLine();