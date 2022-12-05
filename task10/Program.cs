/*
 Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

Console.WriteLine("Введите трёхзначное число.");
int num = int.Parse(Console.ReadLine());
int secondNum = int.Parse(Convert.ToString(num)[1].ToString());
Console.WriteLine($"Второе число - {secondNum}");


