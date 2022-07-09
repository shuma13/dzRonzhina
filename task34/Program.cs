// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2

void FillAray(int[] cal)
{
    int length = cal.Length;
    for (int i = 0; i < length; i++)
    {
        cal[i] = new Random().Next(100, 1000);
    }
}
void ShowArray(int[] arrayToShow)
{
    Console.Write("[");
    for (var i = 0; i < arrayToShow.Length; i++)
    {
        Console.Write(arrayToShow[i]);
        if (i < arrayToShow.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}
int GetCountEvenNumbers(int[] array)
{
    int length = array.Length;
    int count = 0;
    int c =0;
    for (int i = 0; i < length; i++)
    {
        c = array[i] % 2;
        if (c == 0)
        {
            count = count + 1;
        }
    }
    return count;
}
Console.WriteLine("Введите длину массива.");
int lenght = Convert.ToInt32(Console.ReadLine());
int[] arrayNum = new int[lenght];
FillAray(arrayNum);
ShowArray(arrayNum);
int count = GetCountEvenNumbers(arrayNum);
System.Console.WriteLine($"В заданном массиве {count} четных чисел");