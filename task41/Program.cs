/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3
*/

Console.WriteLine("Введите количесиво элементов массива:\t");
int arraySize = int.Parse(Console.ReadLine());
int[] array = new int[arraySize];


for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Введите элемент массива для заполнения ячейки под индексом {i}:\t");
    array[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Вывод массива:");
PrintArray(array);

int count = 0;
 
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        count++;
    }
}
 
Console.WriteLine($"Кол-во элементов больше 0: {count}");


void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}