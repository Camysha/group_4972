// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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

void MinSumRow (int[,] arr)
{
    int outN =0;
    int sum = int.MaxValue;

    for (int i = 0; i < arr.GetLength(0); i++ )
    {
        int sumRaw = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sumRaw = sumRaw + arr.GetLength(1);
        }
        if (sumRaw < sum)
        {
            sum = sumRaw;
            outN = i;
            Console.WriteLine("Строка с наименьшей суммой элементов: ");
            Console.Write($"{outN + 1}");
        }

    }

    
}



int[,] arr2D = Fill2DArray(2,2,5,1);
Print2DArray(arr2D);

MinSumRow(arr2D);

