/*Задача 62. Заполните спирально массив 4 на 4.

Например, на выходе получается вот такой массив:

1 2 3 4

12 13 14 5

11 16 15 6

10 9 8 7*/

int[,] GetSpiralNumberArray(int rowNumber, int colNumber)
{
    int[,] matrix = new int[rowNumber, colNumber];
    int number = 1;
    int x = 0;
    int y = 0;
    int maxNamber = rowNumber * colNumber;
    while (number <= maxNamber)
    {
        for (int j = y; j < colNumber; j++)
        {
            matrix[x, j] = number;
            number++;
        }
        for (int i = x + 1; i < rowNumber; i++)
        {
            matrix[i, colNumber - 1] = number;
            number++;
        }
        for (int j = colNumber - 2; j >= y; j--)
        {
            matrix[rowNumber - 1, j] = number;
            number++;
        }
        for (int i = rowNumber - 2; i > x; i--)
        {
            matrix[i, y] = number;
            number++;
        }
        colNumber = colNumber - 1;
        rowNumber = rowNumber - 1;
        x = x + 1;
        y = y + 1;
    }
    return matrix;
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
int[,] matrix = GetSpiralNumberArray(4, 4);
Print2DArray(matrix);