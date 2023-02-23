//Задача № 60
//Сформируйте трехмерный массив из неповторяющихся двухзначных чисел.
//Напишите программу которая будет построчно выводить массив, добавляя индексы каждого элемента.


 Console.Clear();

Console.Write("Введите количество элементов по оси х: ");
int x = int.Parse(Console.ReadLine());

Console.Write("Введите количество элементов по оси у: ");
int y = int.Parse(Console.ReadLine());

Console.Write("Введите количество элементов по оси z: ");
int z = int.Parse(Console.ReadLine());

int[,,] ArrayCub(int x1, int y1, int z1)
{   
    int count = 10;
    int[,,] arrCub = new int[x1, y1, z1];
    for(int i = 0; i < arrCub.GetLength(0); i++)
    {
        for(int j = 0; j < arrCub.GetLength(1); j++)
        {
            for(int k = 0; k < arrCub.GetLength(2); k++)
            {
              arrCub[i,j,k] = count;
              count++;
            }        
        }
    }
    return arrCub;
}

int[,,] arrayCub = ArrayCub(x, y, z);

void PrintArray(int[,,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            for(int k = 0; k < arr.GetLength(2); k++)
            {
                Console.Write($"{arr[i, j, k]}[{i}, {j}, {k}] ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
PrintArray(arrayCub);
Console.WriteLine();

void PrintArrayRows(int[,,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            for(int k = 0; k < arr.GetLength(2); k++)
            {
                Console.Write($"{arr[j, k, i]}[{j}, {k}, {i}] ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Вывод построчно:");
PrintArrayRows(arrayCub);
Console.WriteLine();