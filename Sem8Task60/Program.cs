// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[,,] Fill3DArray(int countRow, int countColumn, int countPages, int topBorder, int downBorder)
{
    int[,,] array3D = new int[countRow, countColumn, countPages];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
           for (int k = 0; k < countPages; k++)
            {
                array3D[k, i, j] = new Random().Next(downBorder, topBorder + 1);
            }
        }
    }
    return array3D;
}

void Print3DArray(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
             Console.WriteLine();
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k]}({i},{j},{k}) ");
            }
        }
    }
}

int[,,] arr3D = Fill3DArray(2,2,2,10,1);
Print3DArray(arr3D);
