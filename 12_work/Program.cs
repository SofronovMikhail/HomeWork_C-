Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());
int Sum(int num)
{
    int result = 0;
    int count = 0;
    int[] array = new int[num];
    for(int i = 0; num >= 1; i++)
    {
        array[i] = num % 10;
        num /= 10; 
        count ++;  
    }
    for(int j = 0; j < count; j++)
    {
      result += array[j];  
    }
    return result;
}
Console.WriteLine($"сумма чисел = {Sum(n)}");
