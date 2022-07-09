// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76

void FillAray(double[] cal)
{
    int length = cal.Length;
    for (int i = 0; i < length; i++)
    {
        cal[i] = new Random().Next(-10, 10);
    }
}
void ShowArray(double[] arrayToShow)
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
double GetDifferenceMaxMinNunber(double[] arrayDif)
{
    int length = arrayDif.Length;
    double dif = 0;
    double maxNumber = 0;
    double minNumber = 0;
    if (arrayDif[0] > arrayDif[1])
    {
        maxNumber = arrayDif[0];
        minNumber = arrayDif[1];
    }
    else
    {
        maxNumber = arrayDif[1];
        minNumber = arrayDif[0];
    }
    for (int currentIndex = 2; currentIndex < length; currentIndex++)
    {
        if (arrayDif[currentIndex] > maxNumber)
        {
            maxNumber = arrayDif[currentIndex];
        }
        else if (arrayDif[currentIndex] < minNumber)
        {
            minNumber = arrayDif[currentIndex];
        }



    }
    dif = maxNumber - minNumber;
    return dif;
}
Console.WriteLine("Введите длину массива.");
int lenght = Convert.ToInt32(Console.ReadLine());
double[] arrayNum = new double[lenght];
FillAray(arrayNum);
ShowArray(arrayNum);
double dif = GetDifferenceMaxMinNunber(arrayNum);
Console.WriteLine($"Разница между минимальным и максимальным элементами массива равна {dif}");