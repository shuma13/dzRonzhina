/*Задача 50. Напишите программу, которая на вход принимает позицию элемента в двумерном массиве,
 и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет*/
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
int GetSearchNumber(int[,] arr, int position)
{
    int rowNumber = arr.GetLength(0);
    int colNumber = arr.GetLength(1);
    int[,] matrix = new int[rowNumber, colNumber];
    int number = 0;
    for (int i = 0; i < rowNumber; i++)
    {
        for (int j = 0; j < colNumber; j++)
        {
            matrix[i, j] = number;
            number++;
        }
    }
    Print2DArray(matrix);
    int findI = 0;
    int findJ = 0;
    for (int i = 0; i < rowNumber; i++)
    {
        for (int j = 0; j < colNumber; j++)
        {
            if (matrix[i, j] == position)
            {
                findI = i;
                findJ = j;
                break;
            }
        }
    }
    return arr[findI, findJ];
}

int[,] array = GenerateArray(3, 4, 20);
Print2DArray(array);
Console.Write("Введите заначение искомой позиции : ");
int position = Convert.ToInt32(Console.ReadLine());
int maxNumberPosition = (array.GetLength(0) * array.GetLength(1)) - 1;
if (position > maxNumberPosition || position < 0)
{
    Console.WriteLine($"Такого числа в массиве нет - допустимое значение от 0 до {maxNumberPosition}");
}
else
{
    int result = GetSearchNumber(array, position);
    Console.WriteLine($"Искомый элемент равен :{result}");
}