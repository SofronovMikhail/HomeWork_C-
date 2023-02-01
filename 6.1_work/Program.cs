Console.Clear();
Console.Write("Введите число: ");
string number = Console.ReadLine();
string num = Convert.ToString(number[2]);
Console.WriteLine($"{number} = {num}");
if (number.Length < 3){
    Console.WriteLine("третьего числа нет");
}
