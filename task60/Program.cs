/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

Console.WriteLine("Введите размерность 1: ");
int size1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите размерность 2: ");
int size2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите размерность 3: ");
int size3 = int.Parse(Console.ReadLine());

int count = 99;

if (size1 * size2 * size3 > count)
{
    Console.Write("Массив слишком большой!!!");
    return;
}

int[,,] resultNums = Create3DArray(size1, size2, size3);

for (int i = 0; i < resultNums.GetLength(0); i++)
{
    for (int j = 0; j < resultNums.GetLength(1); j++)
    {
        for (int k = 0; k < resultNums.GetLength(2); k++)
        {
            Console.WriteLine($"[{i},{j},{k}] - {resultNums[i, j, k]}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}




int[,,] Create3DArray(int size1, int size2, int size3)
{
    int[,,] array = new int[size1, size2, size3];
    int[] values = new int[count];
    int rnd = new Random().Next(0, values.Length);
    int num = 10;
    for (int i = 0; i < values.Length; i++)
        values[i] = num++;

    for (int i = 0; i < values.Length; i++)
    {
        int temp = values[i];
        values[i] = values[rnd];
        values[rnd] = temp;
    }




    int valueIndex = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = values[valueIndex++];
            }
        }
    }
    return array;
}