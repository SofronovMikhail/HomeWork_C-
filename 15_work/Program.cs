Console.Clear();
Console.WriteLine("Введите значения массива через пробел: ");
string arraySt = Console.ReadLine();
int[] Array(string array)
{
    string[] array1 = array.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] res = new int[array1.Length];
    for(int i = 0; i < array1.Length; i++)
    {
        res[i] = int.Parse(array1[i]);
    }
    return res;
}
int[] arr1 = Array(arraySt); 
Console.WriteLine($"[{String.Join(", ", arr1)}]");

int[] Array1(int[] mas)
{
    
    if(mas.Length%2==0)
    {
        int[] mas1 = new int[mas.Length / 2];
       for(int i = 0; i < mas1.Length; i++)
       {
         mas1[i] = mas[i]*mas[(mas.Length-1)-i]; 
       }
    return mas1;
    }
    else
    {
      int[] mas1 = new int[(mas.Length / 2)+1];  
      for(int i = 0; i < mas1.Length-1; i++)
        {
          mas1[i] = mas[i]*mas[(mas.Length-1)-i];
        }
        mas1[mas.Length / 2] = mas[mas.Length / 2];
    return mas1;
    }
}
int[] arr2 = Array1(arr1);
Console.WriteLine($"[{String.Join(", ", arr2)}]");