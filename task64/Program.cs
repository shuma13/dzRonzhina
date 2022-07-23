/*Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в 
промежутке от M до N.

M = 1; N = 5. -> ""1, 2, 3, 4, 5""

M = 4; N = 8. -> ""4, 6, 7, 8""*/

void naturalNumbersofMBeforN(int M, int N)
{
    if (M < N)
    {
        Console.Write($"{M}, ");
        naturalNumbersofMBeforN(M + 1, N);

    }
    else
    {
        Console.Write($"{N}");
    }
}

Console.WriteLine("Введите начальное число :");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите конечное число :");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write($"M = {M}; N = {N}. ->");
naturalNumbersofMBeforN(M,N);