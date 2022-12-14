/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*/

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
FillArrayRndElem(array);
Console.WriteLine("Это массив: ");
PrintArray(array);

int sum = 0;
for ( int s = 0; s < array.Length; s+=2)
{
    sum = sum + array[s];
}
Console.WriteLine($"{sum}  - сумма элементов, стоящих на нечётных позициях");

void FillArrayRndElem(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10,10);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

