﻿//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125
int num = new Random().Next(1, 30);
System.Console.WriteLine($"Таблица кубов чисел от 1 до {num}");
for (int i = 1; i <= num; i++)
{
    System.Console.WriteLine($"Куб числа {i} равен {Math.Pow(i, 3)}");
}