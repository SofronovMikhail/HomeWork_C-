Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());
int i = 1;
int m = n;
if(n < 0)
{
i = n;
m=-n;
n=-1;
}
int[] array = new int[m];
for(int j = 0; i<=n; i++)
{
   array[j] = i * i * i;
   j++;
}
for(int j = 0; j < m; j++)
{
    Console.WriteLine($"{array[j]}");
}