﻿// Урок 4. Функции

// Задача 25: Напишите цикл, который принимает на вход два 
// числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16
// int number1 = ReadInt("Введите число A: ");
// int number2 = ReadInt("Введите число B: ");
// ToDegree(number1, number2);


// Функция возведения в степень
// void ToDegree(int a, int b)
// {
//     int result = 1;
//     for (int i = 1; i <= b; i++)
//     {
//         result = result * a;
//     }
//     System.Console.WriteLine(result);
// }

 // Функция ввода
// int ReadInt(string message)
// {
//     System.Console.WriteLine(message);
//     return Convert.ToInt32(Console.ReadLine());
// }



// Задача 27: Напишите программу, которая принимает на
// вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

// int num = ReadInt("Введите число: ");
// int len = NumberLen(num);
// SumNumbers(num, len);


// Функция ввода
// int ReadInt(string message)
// {
//     System.Console.WriteLine(message);
//     return Convert.ToInt32(Console.ReadLine());
// }

 // Функция подсчета цифр в числе
// int NumberLen(int a)
// {
//     int index = 0;
//     while (a > 0)
//     {
//         a /= 10;
//         index++;
//     }
//     return index;
// }

// Функция вывода суммы цифр в числе
// void SumNumbers(int n, int len)
// {
//     int sum = 0;
//     for (int i = 1; i <= len; i++)
//     {
//         sum += n % 10;
//         n /= 10;
//     }
//     System.Console.WriteLine(sum);
// }

// Задача 29: Напишите программу, которая задаёт массив 
// из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

System.Console.Write("Введите любое число (A): ");
int enterNum = Convert.ToInt32(Console.ReadLine());

int[] array = new int[enterNum];

    for (int i = 0; i < enterNum; i++)
     {
        array[i] = new Random().Next(enterNum+1);
        Console.Write(array[i] + "; ");
    }
     Console.WriteLine();

    