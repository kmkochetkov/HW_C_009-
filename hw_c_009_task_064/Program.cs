﻿// Задача 64: Задайте значение N. Напишите программу, которая выведет все
// натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Рекурсивный метод печати натуральных чисел в промежутке от N до 1 
void PrintNatural(int num)
{
    if (num >=1)
    {
        Console.Write($"{num}, ");
        PrintNatural(num-1);
    }
}


// Ввод числа N
int myNumber = 0;
try
{
    Console.Write("Введите число N: ");
    myNumber = Convert.ToInt32(Console.ReadLine());
}
catch
{    
    Console.WriteLine("Нужно вводить целое число!");
}


Console.Write($"N={myNumber} -> ");
PrintNatural(myNumber);
Console.WriteLine();