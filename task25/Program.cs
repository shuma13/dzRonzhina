//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

//3, 5 -> 243 (3⁵)

//2, 4 -> 16
int GetPowFunc(int numA, int numB)
{
    int power=1;
    for (int i = 0; i < numB; i++)
    {
        power *= numA;
    }
    return power;
}
Console.WriteLine("Введите число A для возведения в степень");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B - степень для числа A");
int numberB = Convert.ToInt32(Console.ReadLine());
int res =GetPowFunc(numberA, numberB);
System.Console.WriteLine($"{numberA} в степени {numberB} равно {res}");