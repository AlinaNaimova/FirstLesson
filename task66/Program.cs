/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

Console.WriteLine("Введите число M: ");
int M = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine());

Console.WriteLine($"Сумма натуральных элементов от {M} до {N} = {CountSum(M, N)}");


int CountSum(int M, int N)
{
    if (M == N)
        return N;
    return N + CountSum(M, N - 1);
}