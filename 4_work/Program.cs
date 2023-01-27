Console.Clear();
Console.Write("Укажите число: ");
int number = int.Parse(Console.ReadLine());
int i = 1;
Console.Write($"{number}: ");
while(i <= number){
    if(i%2 == 0){
      Console.Write($"{i}, ");   
    }
   
    i++;
}