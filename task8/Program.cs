﻿// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());

if (n > 1) {
   Console.Write("Массив четных чисел: ");
   for (int i = 2; i <= n; i = i + 2) {
       Console.Write(i + " ");
    }
}
else {
    Console.Write("Ошибка, n должно быть больше 1");
}