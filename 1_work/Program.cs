Console.Clear();
Console.Write("Укажите 1 число: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Укажите 2 число: ");
int numberB = int.Parse(Console.ReadLine());
if(numberA > numberB){
    Console.WriteLine($"max={numberA}");
}
else{
    Console.WriteLine($"max={numberB}");
}