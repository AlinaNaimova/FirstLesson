/*Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/

Console.WriteLine("Введите пятизначное число.");
    string nums = Console.ReadLine();
    char[] arr = nums.ToCharArray();
    Array.Reverse(arr);
    string nums2 = new String(arr);
 
        if (nums == nums2) 
            Console.WriteLine("Палиндром");
        else 
            Console.WriteLine("Не палиндром");