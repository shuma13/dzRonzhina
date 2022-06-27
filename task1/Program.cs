// Task6
Console.WriteLine("Введите число для проверки на четность");
int number = Convert.ToInt32(Console.ReadLine());
int temp = number % 2;
bool result = temp ==0;
if (result)
{
    Console.WriteLine($"Число {number} является четным");
}
else
{
    Console.WriteLine($"Число {number} является нечетным");
}