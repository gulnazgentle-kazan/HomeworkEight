/*Задача 56: Задайте двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт 
номер строки с наименьшей суммой элементов: 1 строка*/

int[,] GetMatrix(int rows, int colums)
{
    int[,] matrix = new int[rows, colums];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
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

int MinSumRows(int[,] matrix)
{
    int sum = 0;
    int[] sumRows = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
            sumRows[i] = sum;
        }
        sum = 0;
    }
    int minSumRows = sumRows[0];
    int minSumRowsIndex = 1;
    for (int i = 0; i < sumRows.Length; i++)
    {
        if (sumRows[i] < minSumRows)
        {
            minSumRows = sumRows[i];
            minSumRowsIndex = i + 1;
        }
    }
    return minSumRowsIndex;
}
int[,] matrix1 = GetMatrix(3, 3);
PrintMatrix(matrix1);
int minColums = MinSumRows(matrix1);
Console.WriteLine("Строка, сумма элементов, которая минимальная: " + minColums);
