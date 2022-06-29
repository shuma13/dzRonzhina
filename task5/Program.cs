Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
int c = (number / 10) % 10;
Console.WriteLine($"Вторая цифра числа {number}");
Console.WriteLine(c);

