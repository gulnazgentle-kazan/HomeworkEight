/* Задача 58: Задайте две матрицы. 
Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18

(допустимый вариант)
6 16
9 6*/


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

int[,] MatrixMultiplication(int[,] matrix_1, int[,] matrix_2)
{
    if (matrix_1.GetLength(1) != matrix_2.GetLength(0))
    {
        throw new Exception("Умножение не возможно! Количество столбцов первой матрицы не равно на количеству строк второй матрицы.");
    }
    int[,] Result_Matrix = new int[matrix_1.GetLength(0), matrix_2.GetLength(1)];
    for (int i = 0; i < matrix_1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix_2.GetLength(1); j++)
        {
            Result_Matrix[i, j] = 0;
            for (int l = 0; l < matrix_1.GetLength(1); l++)
            {
                Result_Matrix[i, j] += matrix_1[i, l] * matrix_2[l, j];
            }
        }
    }
    return Result_Matrix;
}
Console.WriteLine("Матрица А:");
int[,] matrix1 = GetMatrix(2, 2);
PrintMatrix(matrix1);
Console.WriteLine("Матрица Б:");
int[,] matrix2 = GetMatrix(2, 2);
PrintMatrix(matrix2);
Console.WriteLine("Результат умножения матриц А и Б:");
int[,] resultMatrix = MatrixMultiplication(matrix1, matrix2);
PrintMatrix(resultMatrix);