﻿// Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите степень числа,  в которую нужно возвести");
int b = Convert.ToInt32(Console.ReadLine());

int DegreeOfNumber(int a, int b)
{
    int res = 1;

    for (int i = 1; i <= b; i++)
    {
        res *= a;
    }
    return res;
}

Console.WriteLine($"Ответ: {DegreeOfNumber(a, b)}");
