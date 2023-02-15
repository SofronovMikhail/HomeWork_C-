Console.Clear();
Console.Write("Введите значени b1: ");
double b1 = int.Parse(Console.ReadLine());
Console.Write("Введите значени k1: ");
double k1 = int.Parse(Console.ReadLine());
Console.Write("Введите значени b2: ");
double b2 = int.Parse(Console.ReadLine());
Console.Write("Введите значени k2: ");
double k2 = int.Parse(Console.ReadLine());

double Sum1(double b3, double k3, double b4, double k4)
{
double x = (b4 - b3) / (k3 - k4);
return x;
}
double x1 = Sum1(b1, k1, b2, k2);

double Sum(double b3, double k3, double x)
{
double y = k3 * x + b3;
return y;
} 
double sum = Sum(b1, k1, x1);
if(x1 == 0 || sum == 0)
{
    Console.WriteLine("Прямые не пересекаються");
}
else
{
    Console.WriteLine($"Точка пересечения двух прямых = ({x1},{sum})");
}
