Console.Clear();
Console.Write("Введите день недели: ");
int num = int.Parse(Console.ReadLine());
if(num <= 0 || num > 7){
    Console.WriteLine("Не правильное число");
    return;
}
if(num > 5 && num < 8){
    Console.WriteLine("Да");
}
else{
    Console.WriteLine("Нет");
}
