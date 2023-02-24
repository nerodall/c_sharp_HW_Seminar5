// Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 26
// [-4, -6, 4, 6] -> 0


int[] GenerateArray()
{
    int[] array = new int[5];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10,11);
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

int SumUneven (int [] array)
{
   int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 0)
        {
            sum = sum + array[i];
        }
    }
    return sum;
}

int [] array = GenerateArray();
PrintArray(array);
System.Console.WriteLine();
System.Console.WriteLine($"Сумма элементов массива стоящих на нечетных позициях равна {SumUneven(array)} ");