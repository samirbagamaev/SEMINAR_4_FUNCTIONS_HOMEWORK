﻿// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

// Возведение в степень - Exponentiation

int Exponentiation (int numberA, int numberB)
{
    int result = 1;
    for(int i = 1; i <= numberB; i++)
    {
        result = result * numberA;
    }
    return result;
}
int exponentiation = Exponentiation(numberA, numberB);
Console.WriteLine(exponentiation);