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
int[] arr = Array(arraySt); 
Console.WriteLine(String.Join(" ", arr));

int[] Array1(int[] array2)
{
    int[] arr = new int[array2.Length / 2];
    if(array2.Length / 2 == 0){
    for(int i = 0; i < array2.Length / 2; i++)
    {
       arr[i] = array2[i] * array2[array2.Length - i];
    }
    }
    else{
    for(int i = 0; i < (array2.Length / 2) + 1; i++)
    {
       arr[i] = array2[i] * array2[array2.Length - i];
    }
    }
    return arr;
}
int[] arr1 = Array1(arr);
Console.WriteLine(String.Join(" ", arr1));

