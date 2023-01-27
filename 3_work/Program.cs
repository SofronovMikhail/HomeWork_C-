Console.Clear();
Console.Write("Укажите число: ");
int number = int.Parse(Console.ReadLine());
if(number%2 == 0){
    Console.WriteLine("Да");
}
else{
    Console.WriteLine("Нет");
}

