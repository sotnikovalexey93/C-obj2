﻿/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

Console.WriteLine ("Введите трехзначное число");
string NumberStr1 = Console.ReadLine();
int number = Convert.ToInt32 (NumberStr1);

Console.WriteLine(NumberStr1[1]);
