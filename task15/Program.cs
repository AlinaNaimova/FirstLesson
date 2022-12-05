/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/
Console.WriteLine("Введите число: "); 
int num = Convert.ToInt16(Console.ReadLine()); 
switch (num) 
{ 
    case 1: Console.WriteLine("нет"); break; 
    case 2: Console.WriteLine("нет"); break; 
    case 3: Console.WriteLine("нет"); break; 
    case 4: Console.WriteLine("нет"); break; 
    case 5: Console.WriteLine("нет"); break; 
    case 6: Console.WriteLine("да"); break; 
    case 7: Console.WriteLine("да"); break; 
    default: Console.WriteLine("Ошибка. Введите число от 1 до 7!!!"); break; 
}