/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/

int[,,] ThreedMatrix(int rows, int colums, int width)
{
    int[,,] threed_matrix = new int[rows, colums, width];
    for (int i = 0; i < threed_matrix.GetLength(0); i++)
    {
        for (int j = 0; j < threed_matrix.GetLength(1); j++)
        {
            for (int k = 0; k < threed_matrix.GetLength(2); k++)
            {
                threed_matrix[i, j, k] = new Random().Next(10, 100);
                Thread.Sleep(11); // Ходят слухи, что рандом каждый 18 сек генерирует те же числа. 
                                  // Мы обходим этот закон
            }
        }
    }
    return threed_matrix;
}

void PrintThreedMatrix(int[,,] threedMatrix)
{
    for (int i = 0; i < threedMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < threedMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < threedMatrix.GetLength(2); k++)
            {
                Console.WriteLine(threedMatrix[i, j, k] + " -> " + (i, j, k));
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

int[,,] matrix1 = ThreedMatrix(2, 2, 2);
PrintThreedMatrix(matrix1);