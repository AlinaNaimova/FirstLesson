/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение 
этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет
*/

int row = GetNumber("Введите  номер строки:");
int column = GetNumber("Введите номер столбца:");
int[,] matrix = new int[5,5];
FillMatrixRandomNumbers(matrix);

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

if(row > matrix.GetLength(0) || column > matrix.GetLength(1))
{
    Console.WriteLine("Такого числа в массиве нет :(");
}
else
{
    Console.WriteLine($"Значение элемента {row} строки и {column} столбца равно {matrix[row-1,column-1]}");
}


void FillMatrixRandomNumbers(int[,] matrix)
{
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(-100, 100)/10;
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j] + " ");
        }   
        Console.WriteLine(""); 
    }
}