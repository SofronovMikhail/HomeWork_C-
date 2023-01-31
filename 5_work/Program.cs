Console.Clear();
Console.Write("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());
int num1 = number / 10;
if(num1 %10 == 0){
    Console.WriteLine(0);
}
else{
    Console.WriteLine(num1%10);
}

