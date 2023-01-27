Console.Clear();
Console.Write("Укажите 1 число: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Укажите 2 число: ");
int numberB = int.Parse(Console.ReadLine());
Console.Write("Укажите 3 число: ");
int numberC = int.Parse(Console.ReadLine());
int max = numberA;
if(numberB > max){
    max = numberB;
}
if(numberC > max){
    max = numberC;
}
Console.WriteLine($"max = {max}");
