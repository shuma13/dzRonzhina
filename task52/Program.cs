/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в 
каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

int[,] GenerateArray(int rowNumber, int colNumber, int deviation)
{
    int[,] result = new int[rowNumber, colNumber];
    for (int i = 0; i < rowNumber; i++)
    {
        for (int j = 0; j < colNumber; j++)
        {
            result[i, j] = new Random().Next(-deviation, deviation + 1);
        }
    }
    return result;
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
double[] GetArithmeticalMeanColumn(int[,] arr)
{
    int colNumber = arr.GetLength(1);
    int rowNumber = arr.GetLength(0);
    double[] arithmeticalMeanArray = new double[colNumber];
    double sum = 0;
    for (int j = 0; j < colNumber; j++)
    {
        for (int i = 0; i < rowNumber; i++)
        {
            sum = sum + arr[i, j];
        }
        arithmeticalMeanArray[j] = Math.Round((sum / rowNumber), 1);
        sum = 0;
    }
    return arithmeticalMeanArray;
}
void ShowArray(double[] arrayToShow)
{
    for (var i = 0; i < arrayToShow.Length; i++)
    {
        Console.Write(arrayToShow[i]);
        if (i < arrayToShow.Length - 1)
        {
            Console.Write("; ");
        }
    }
    Console.WriteLine(".");
}

int[,] array = GenerateArray(3, 4, 20);
Print2DArray(array);
double[] result = GetArithmeticalMeanColumn(array);
ShowArray(result);