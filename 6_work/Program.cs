Console.Clear();
Console.Write("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());
int num1 = number / 100;
if(num1 > 0 && num1 < 10){
    Console.WriteLine(number%10);
}
else{
    Console.WriteLine("Не правильное число");
}