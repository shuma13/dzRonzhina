// Задача 13 2 семинар
Console.WriteLine("Введите число для нахождения его третьей цифры");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100)
{
    System.Console.WriteLine("Число двухзначное третьей цифры нет");
}
else if (number > 999)
{ 
    int number1 = number;
    while (number1 > 999)
    {
        number1 = number1 / 10;
        System.Console.WriteLine(number1);
    }
    int c = number1 % 10;
    System.Console.WriteLine($"Третья цифра числа {number}");
    System.Console.WriteLine(c);
}
else 
{
    int c = number % 10;
    System.Console.WriteLine($"Третья цифра числа {number}");
    System.Console.WriteLine(c);
}