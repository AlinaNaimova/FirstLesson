/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/
int row = GetNumber("Введите количество строк:");
int column = GetNumber("Введите количество столбцов:");
int[,] numbers = new int[row, column];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);
SortElements(numbers);
Console.WriteLine("Массив с упорядоченными элементами:");
PrintArray(numbers);

int GetNumber(string message)
{
    int result = 0;

    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число");
        }
    }

    return result;
}

void FillArrayRandomNumbers(int[,] numbers)
{
    Random rnd = new Random();
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            numbers[i, j] = rnd.Next(1, 10);
        }
    }
}

void PrintArray(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            Console.Write(numbers[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

void SortElements(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
         for (int j = 0; j < numbers.GetLength(1) - 1; j++)
        {
             for (int z = 0; z < numbers.GetLength(1) - 1; z++)
            {
                if (numbers[i, z] < numbers[i, z + 1])
                {
                    int element = 0;
                    element = numbers[i, z];
                    numbers[i, z] = numbers[i, z + 1];
                    numbers[i, z + 1] = element;
                }
            }
        }
    }
Console.WriteLine();
}