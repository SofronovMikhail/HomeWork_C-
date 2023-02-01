Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int num1 = 1;
if(number < 100){
   Console.WriteLine("Третьей цифры нет."); 
}
else{
  while(number / num1 > 99){
    num1 = num1 * 10;
  }  
  int num2 = (number % num1) / (num1 / 10);
  Console.WriteLine(num2);
}



