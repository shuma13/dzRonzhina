/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку 
с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой 
элементов: 1 строка*/

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

int GetRowMinSum(int[,] matrix)
{
    int size = matrix.GetLength(0);
    int[] array = new int[size];
    int minSum = 0;
    int minRow = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[i] += matrix[i, j];

        }
    }
    minSum = array[0];
    foreach (var item in array)
    {
        System.Console.Write(item + ",");
    }
    System.Console.WriteLine();
    for (int i = 1; i < size; i++)
    {
        if (array[i] < minSum)
        {
            minSum = array[i];
            minRow = i;
        }
    }
    return minRow;
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
int[,] masiv = GenerateArray(4, 4);
Print2DArray(masiv);
Console.WriteLine();
int result = GetRowMinSum(masiv);
Console.WriteLine($"строка с наименьшей суммой элементов: {result} строка ");