//Задача 66:
//Задайте значения  M и N.
//Напишите программу, которая найдет сумму натуральных элементов в промежутке от M до N.


Console.Clear();

Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());
Console.Write("Введите число M: ");
int M = int.Parse(Console.ReadLine());

int SumNum(int n1, int m1)
{   
    if(m1 == n1)
    {
        return n1;
    }
      return (m1 + SumNum(n1, m1 - 1));
}
Console.WriteLine(SumNum(N, M));
