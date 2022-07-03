// Задача 23 3 семинар
Console.WriteLine("Введите число N");
int i;
int N = Convert.ToInt32(Console.ReadLine());
double cube;
for(i=1; i<=N; i++)
{
    cube = Math.Pow(i,3);
    System.Console.Write(cube);
    if (i!=N)
    {
        System.Console.Write(",");
    }
}
