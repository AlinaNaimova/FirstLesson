/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

Console.Write("Введите размер матриц: ");
int size = int.Parse(Console.ReadLine());

    int[,] matrixA = GetArray(size, size, 0, 10);
    int[,] matrixB = GetArray(size, size, 0, 10);
    PrintArray(matrixA);
    Console.WriteLine();
    PrintArray(matrixB);
    Console.WriteLine();
    Console.WriteLine("Результирующая матрица будет:");
    PrintArray(GetMultiplicationMatrix(matrixA, matrixB));

    int[,] GetArray(int m, int n, int min, int max)
    {
      int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
      for (int j = 0; j < n; j++)
      {
        result[i, j] = new Random().Next(min, max + 1);
      }
      
    }
      return result;
    }

    void PrintArray(int[,] inArray)
    {
     for (int i = 0; i < inArray.GetLength(0); i++)
     {
       for (int j = 0; j < inArray.GetLength(1); j++)
       {
         Console.Write($"{inArray[i, j]} ");
       }
       Console.WriteLine();
     }
    }

    int [,] GetMultiplicationMatrix(int[,] matrixA, int[,] matrixB)
    {
      int[,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
      for (int i = 0; i < matrixA.GetLength(0); i++)
      {
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
          for (int k = 0; k < matrixA.GetLength(1); k++)
          {
            matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
          }
        }
      }
      return matrixC;
    }
