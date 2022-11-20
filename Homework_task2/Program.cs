// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.WriteLine("Введите число");
string num = Console.ReadLine();

 int SumNumbers(string num)
{
     int res = 0;
     int [] array = new int[num.Length];

    for(int i = 0; i < array.Length; i++)
        {    
              array[i] = int.Parse(Convert.ToString(num[i]));
              res += array[i];
        }
        return res; 
}

  Console.WriteLine($"Ответ: {SumNumbers(num)}");