
// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18



int[,] Fill2DArray(int countRow, int countColumn, int topBorder, int downBorder)
{
    int[,] array2D = new int[countRow, countColumn];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i, j] = new Random().Next(downBorder, topBorder + 1);
        }
    }
    return array2D;
}

void Print2DArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void ProductMatrices(int[,] MatrixOne, int[,] MatriTwo, int[,] MatrixResult)
{
  for (int i = 0; i < MatrixResult.GetLength(0); i++)
  {
    for (int j = 0; j < MatrixResult.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < MatrixOne.GetLength(1); k++)
      {
        sum += MatrixOne[i,k] * MatriTwo[k,j];
      }
      MatrixResult[i,j] = sum;
    }
  }
}

int [,] matrix1 = Fill2DArray(4,4,10,1);
Print2DArray(matrix1);
int [,] matrix2 = Fill2DArray(4,4,10,1);
Print2DArray(matrix1);
int[,] matrixres = new int[4,4];
ProductMatrices(matrix1, matrix2, matrixres);
Console.WriteLine($"Произведение первой и второй матриц:");
Print2DArray(matrixres);

