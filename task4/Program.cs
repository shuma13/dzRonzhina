// Task4
Console.WriteLine("Введите первое число для нахлждения максимального заначения");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число для нахлждения максимального заначения");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число для нахлждения максимального заначения");
int numberC = Convert.ToInt32(Console.ReadLine());
int max = numberA;
if (numberB > max)  max = numberB;
if (numberC > max) max = numberC;
Console.WriteLine($"Максимальное число = {max}");
