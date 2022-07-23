/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных 
элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/
int SumNumbers (int M, int N)
{
    if(M > N)
    {
        return 0;
    }
else
{
    return M + SumNumbers(M + 1, N);  
}
}
Console.WriteLine("Введите начальное число :");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите конечное число :");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write($"M = {M}; N = {N}. ->");
int sum = SumNumbers(M,N);
Console.WriteLine(sum);

