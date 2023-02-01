Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int num1 = 10;
int num2 = number / num1;
if(num2 > 10 && num2 < 100){
    Console.WriteLine(number%num1);
    return;
}
else if(num2 < 10){
   Console.WriteLine("Третьей цифры нет.");
   return;
}
while(number / num1 > 99)
{
     num1 = num1 * 10;
}
int num3 = (number % num1) / (num1 / 10);
Console.WriteLine(num3);


