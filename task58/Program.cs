/*Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.*/

int[,] GenerateArray(int rowNumber, int colNumber)
{
    int[,] result = new int[rowNumber, colNumber];
    for (int i = 0; i < rowNumber; i++)
    {
        for (int j = 0; j < colNumber; j++)
        {
            result[i, j] = new Random().Next(1, 10);
        }
    }
    return result;
}

int[,] GetCompositionMatrix(int[,] arr1, int[,] arr2)
{
    int colNumber = arr1.GetLength(1);
    int rowNumber = arr1.GetLength(0);
    int[,] result = new int[rowNumber, colNumber];
    for (int i = 0; i < rowNumber; i++)
    {
        for (int j = 0; j < colNumber; j++)
        {
            result[i, j] = GenerateElementArray(arr1, arr2, i, j);
        }
    }
    return result;
}

int GenerateElementArray(int[,] arr1, int[,] arr2, int x, int y)
{
    int res = 0;
    for (int j = 0; j < arr1.GetLength(1); j++)
    {
        int c = arr1[x, j] * arr2[j, y];
        res = res + c;
    }
    return res;
}
void PrintGreen(int number)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write($"{number}\t");
    Console.ResetColor();
}
void Print2DArray(int[,] arrayToPrint)
{
    Console.Write(" \t");
    for (var i = 0; i < arrayToPrint.GetLength(1); i++)
    {
        PrintGreen(i);
    }
    Console.WriteLine();
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        PrintGreen(i);
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write(arrayToPrint[i, j]);
            if (j < arrayToPrint.GetLength(1) - 1)
            {
                Console.Write("\t");
            }
        }
        Console.WriteLine();
    }
}
int[,] array1 = GenerateArray(4, 4);
int[,] array2 = GenerateArray(4, 4);
Print2DArray(array1);
Console.WriteLine();
Print2DArray(array2);
int [,] matrix = GetCompositionMatrix( array1,array2);
Console.WriteLine();
Print2DArray(matrix);