// Задача со 2 семинара
Console.WriteLine("Введите число для проверки кратности 7 и 23");
int number = Convert.ToInt32(Console.ReadLine());
int c = number % 23;
int d = number % 7;
if (c ==0 && d == 0)
{
    System.Console.WriteLine("Число одновремено кратно 7 и 23");
}
else 
{
    System.Console.WriteLine("Нет - Число одновремено не кратно 7 и 23");
}
