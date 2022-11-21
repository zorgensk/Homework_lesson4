// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.



int[] array = new int[8];

void RandomArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"[{i}] =  {arr[i] = new Random().Next(1, 100)}");
    }
}

RandomArray(array);
