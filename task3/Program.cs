// Task2
Console.WriteLine("Введите первое число");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA > numberB)
{
    Console.WriteLine($"Число {numberA} больше числа {numberB}");
}
else if (numberB > numberA)
{
    Console.WriteLine($"Число {numberB} больше числа {numberA}");
}
else
{
    Console.WriteLine($"Число {numberA} равно числу {numberB}");
}