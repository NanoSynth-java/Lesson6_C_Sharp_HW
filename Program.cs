﻿// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// Console.WriteLine("Введите размер массива: ");
// int m = Convert.ToInt32(Console.ReadLine());
// int[] array = new int [m];
// int size = array.Length;
// int count = 0;
// for (int i = 0; i < size; i++)
// {
//     array[i] = Convert.ToInt32(Console.ReadLine());
//     if (array[i] > 0)
//     {
//         count++;
//     }
// }
// Console.WriteLine($"Количество чисел больше 0 -> {count}");


// Задача 42: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("b1 = ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("k1 = ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("b2 = ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("k2 = ");
double k2 = Convert.ToDouble(Console.ReadLine());

double x = (b2 - b1) / (k1- k2);
double y = k1 * x + b1;
Console.WriteLine($"{x};{y}");