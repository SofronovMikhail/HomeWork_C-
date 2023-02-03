Console.Clear();
Console.Write("Введите пятизначное число: ");
int n = int.Parse(Console.ReadLine());
if(n < 10000 || n > 99999)
{
  Console.WriteLine("Не правильное число");
  return;
}
int m = 5;
int n1 = 10000;
int[] mass = new int[m];
int j = 0;
for(int i = 1; i<=mass.Length; i++)
{
    mass[j] = n/n1;
     n = n % n1;
    n1 = n1 / 10;
    j++;
}
if(mass[0] == mass[4] || mass[1] == mass[3])
{
    Console.WriteLine("yes");
}
else
{
    Console.WriteLine("no");
}
