//Задача 21 3 семинар
Console.WriteLine("Введите координату первой точки по оси X");
double Ax = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату первой точки по оси Y");
double Ay = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату первой точки по оси Z");
double Az = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату второй точки по оси X");
double Bx = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату второй точки по оси Y");
double By = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату второй точки по оси Z");
double Bz = Convert.ToDouble(Console.ReadLine());
double distance = Math.Sqrt(Math.Pow((Ax-Bx),2)+Math.Pow((Ay-By),2)+Math.Pow((Az-Bz),2));
System.Console.WriteLine(distance);
