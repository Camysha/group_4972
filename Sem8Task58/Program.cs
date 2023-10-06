// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(matrix[i,j]+" ");
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}

 static int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
    {       
        if (matrixA.GetLength(0) != matrixB.GetLength(1))
        {
            throw new Exception("Умножение не возможно! Количество столбцов первой матрицы не равно количеству строк второй матрицы.");
        }

        var matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];

        for (var i = 0; i < matrixA.GetLength(0); i++)
        {
            for (var j = 0; j < matrixB.GetLength(1); j++)
            {
                matrixC[i, j] = 0;

                for (var k = 0; k < matrixA.GetLength(0); k++)
                {
                    matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
                }
            }
        }
  return matrixC;
    }

int[,] arrOne = Fill2DArray(2,2,10,1);
Print2DArray(arrOne);

Console.WriteLine("-----------------------------------------");

int[,] arrTwo = Fill2DArray(2,2,10,1);
Print2DArray(arrTwo);

Console.WriteLine("-----------------------------------------");

int[,] arrMultiplicattion = MatrixMultiplication(arrOne, arrTwo);
Print2DArray(arrMultiplicattion);