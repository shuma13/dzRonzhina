// Task8
Console.WriteLine("Введите число N");
int number = Convert.ToInt32(Console.ReadLine());
for (int i = 2; i <= number; i +=2) 
{
  Console.Write($"{i}, ");  
}
