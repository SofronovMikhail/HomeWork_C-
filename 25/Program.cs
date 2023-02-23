//Задача 56:
//Задайте прямоугольный двумерный массив.
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.Clear();

Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцoв: ");
int columns = int.Parse(Console.ReadLine());

Console.Write("Введите минимальное значение элементов массива: ");
int min = int.Parse(Console.ReadLine());

Console.Write("Введите максимальное значение элемента массива: ");
int max = int.Parse(Console.ReadLine());

if(rows == columns)
    {
        Console.WriteLine("Массив задан не верно");
        return;
    }

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

int [] ArraySum(int[,] mass)
{
    int[] arraySum = new int[mass.GetLength(0)];
    for(int i = 0; i < mass.GetLength(0); i++)
    {   int sum = 0;
        for(int j = 0; j < mass.GetLength(1); j++)
        {
           sum += mass[i,j]; 
        }
        arraySum[i] = sum;
    }
    return arraySum;
}
int[] sumMass = ArraySum(array);
Console.WriteLine($"{String.Join(" ", sumMass)}");

void MinSumRows(int[] sumMass1)
{   
    int j = 0;
    int min = sumMass1[j];
    for(int i = 1; i < sumMass1.Length; i++)
   {
        if(min > sumMass1[i])
        {
           min = sumMass1[i];
            j=i;
        }
   } 
   Console.WriteLine($"Строка с минимальной суммой элементов = {j+1}");    
}
MinSumRows(sumMass);
