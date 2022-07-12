// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.WriteLine("Введите коэффицент b1...");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите коэффицент k1...");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите коэффицент b2...");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите коэффицент k2...");
double k2 = Convert.ToInt32(Console.ReadLine());
double x = 0;
double y = 0;
if (k1==k2 && b1==b2)
{
    Console.WriteLine("Прямые совпадают и имеют бесконечное множество точек пересечения");
}
else if (k1==k2)
{
    Console.WriteLine("Прямые не имеют точчек пересечения - они параллельны");
} 
else
{
    x= (b2-b1) / (k1-k2);
    y= k1 * x +b1;
    Console.WriteLine($"Точка пересечения заданных прямых ({x};{y})");
}