Console.Clear();
Console.Write("Введите число А: ");
int A = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int B = int.Parse(Console.ReadLine());
int Sum(int sum1, int sum2)
{    
    int sum3 = 1;
    if(sum2 < 1)
    {
       return sum1;
    }
    for(int i = 1; i <= sum2; i++)
    {
        sum3 *= sum1;
    }
    return sum3;
}
Console.WriteLine($"{A} в степени {B} = {Sum(A, B)}");
