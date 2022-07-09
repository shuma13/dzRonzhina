// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19

//[-4, -6, 89, 6] -> 0

void FillAray(int[] cal, int beginNumber, int endNumber)
{
    int length = cal.Length;
    for (int i = 0; i < length; i++)
    {
        cal[i] = new Random().Next(beginNumber, endNumber + 1);
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
int GetSumOddNunbers(int[] arrayNum)
{
    int length = arrayNum.Length;
    int sum = 0;
    for (int i = 0; i < length; i++)
    {
        if (i != 0 && (i % 2) != 0)
        {
            sum = sum + arrayNum[i];
        }

    }
    return sum;
}
Console.WriteLine("Введите длину массива.");
int lenght = Convert.ToInt32(Console.ReadLine());
int[] array = new int[lenght];
Console.WriteLine("Введите начальное число диапазона чисел.");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите конечное число диапазона чисел.");
int numberB = Convert.ToInt32(Console.ReadLine());
FillAray(array, numberA, numberB);
ShowArray(array);
int sum = GetSumOddNunbers(array);
System.Console.WriteLine($"Сумма элементов массива с нечетными индексами равна {sum}");
