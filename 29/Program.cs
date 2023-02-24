//Задача 64:
//Задайте значения N.
//Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.

Console.Clear();

Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());

string StringNum(int num)
{
  if(num == 1)
  {
     return "1";
  }
  return (num.ToString() + ' ' + StringNum(num -1));
}
Console.WriteLine(StringNum(N));
