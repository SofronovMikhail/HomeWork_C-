//Задача № 62:
//Напишите программу, которая заполнит спирально массив 4 на 4.
int x = 4;
int y = 4;
int[,] GetArray1(int x1, int y1)
{
    int count = 10;
    int[,] result = new int[x1, y1];
    for(int k = 0; k < y1; k++)
    {
            int  d =0;
            result[d, k] = count;
            count++;
    }   
    for(int k = 1; k < x1 ; k++)
    {
            int d = 3;
            result[k, d] = count;
            count++;
    }   
    for(int k = 2; k > -1; k--)
    {
            int d = 3;
            result[d,k] = count;
            count++;
    }   
     for(int k = 2; k > 0; k--)
    {
            int d = 0;
            result[k,d] = count;
            count++;
    }   
     for(int k = 1; k < 3; k++)
    {
        int d = 1;
            result[d,k] = count;
            count++;
    }   
     for(int k = 2; k < 3; k++)
    {
            int d = 2;
            result[k,d] = count;
            count++;
    }   
     for(int k = 2; k < 3; k++)
    {
            int d = 1;
            result[k,d] = count;
            count++;
    }   
    return result;
}
int[,] array = GetArray1(x, y);

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
