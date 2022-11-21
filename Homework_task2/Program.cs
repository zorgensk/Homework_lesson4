// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

string arr = Convert.ToString(num);

int SumNumbers(string arr)
{
    int res = 0;
    int[] array = new int[arr.Length];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = int.Parse(Convert.ToString(arr[i]));
        res += array[i];
    }
    return res;
}

Console.WriteLine($"Ответ: {SumNumbers(arr)}");