/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/
Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = new double[size];
FillArrayRndElem(array);
Console.WriteLine("Это массив: ");
PrintArray(array);
double min = array[0];
double max = array[0];

for (int j = 0; j < array.Length; j++)
{
    if (array[j] > max)
        {
            max = array[j];
        }
    if (array[j] < min)
        {
            min = array[j];
        }
}

Console.WriteLine($"Количество чисел {array.Length}. Максимальное значение - {max}, минимальное значение - {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением элементов массива - {max - min}");


void FillArrayRndElem(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
    }
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
