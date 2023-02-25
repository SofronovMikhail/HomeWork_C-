//Задача №68:
//Напишите программу вычисления функции Аккермана с помощью рекурсии.
//Даны два неотрицательных числа m и n.

Console.Clear();

Console.Write("Введите число m: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите число n: ");
int n = int.Parse(Console.ReadLine());

int Akkerman(int M, int N)
{
    if(M == 0)
    {
        return (N + 1);
    }
    else if(M > 0 && N == 0)
    {
         return (Akkerman(M - 1, 1));
    }
    else if(M > 0 && N > 0)
    {
        return (Akkerman(M-1, Akkerman(M, N-1)));
    }
    else
    {
       return (N + 1);
    }
}

Console.WriteLine(Akkerman(m,n));
