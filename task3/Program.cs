// Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

int[] GenerateArray()
{
    int[] array = new int[5];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1,11);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        //   System.Threading.Thread.Sleep(50);
        System.Console.Write($"{array[i]} ");
    }
}

void Difference (int [] array)
{
  int MaxValue = array[0];
  int MinValue = array[0];
  int result = 0;

  for (int i = 0; i < array.Length; i++)
  {
    if(array[i]> MaxValue)
    {
        MaxValue=array[i];
    }
    if(array[i]< MinValue)
    {
        MinValue = array[i];
    }
    
  }
  result = MaxValue - MinValue;
  System.Console.WriteLine($"Разница между максимальным ({MaxValue}) и минимальным ({MinValue}) элементами массива равна {result}");
}

int [] array = GenerateArray();
PrintArray(array);
System.Console.WriteLine();
Difference(array);