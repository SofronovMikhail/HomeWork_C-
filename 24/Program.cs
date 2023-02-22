//Задача 54: 
//Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы
//каждой строки двумерноого массива.

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

void BubleSort(int[] arrSort)
{
   for(int i = 0; i < arrSort.Length; i++)
   {
      for(int j = 0; j < arrSort.Length - i - 1; j++)
       {
            if(arrSort[j] < arrSort[j + 1])
           {
                int el = arrSort[j];
                arrSort[j] = arrSort[j + 1]; 
               arrSort[j + 1] = el;
            }
       }
    }
}

void Zamena(int d, int[] mass1, int[,] mass2)
{
    for(int k = 0; k < mass1.Length; k++)
    {
        mass2[d, k] = mass1[k];
    }
}

 int[] arr3 = new int[array.GetLength(1)];
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            arr3[j] = array[i,j];
        }
        BubleSort(arr3);
        Zamena(i, arr3, array);
    }
PrintArray(array);  