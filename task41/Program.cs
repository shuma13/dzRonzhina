// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

//0, 7, 8, -2, -2 -> 2

//1, -7, 567, 89, 223-> 3

int [] Enter(int M)
{
    int[] array = new int [M];
    for (int i = 0; i < M; i++)
    {
    Console.Write($"Введите {i+1}-е число...");
    array[i]= Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

int GetCountNumberPositiv( int []array)
{
    int length = array.Length;
    int count =0;
    for (int i = 0; i < length; i++)
    {
        if (array[i]>0)
        {
            count++;
        }
    }
    return count;
}

Console.WriteLine("Введите количество проверяемых чисел");
int num = Convert.ToInt32(Console.ReadLine());
int [] arr = Enter(num);
foreach (var item in arr)
{
    Console.Write(item + "," );
}
int res = GetCountNumberPositiv(arr);
Console.WriteLine();
Console.WriteLine($"Количество введеных пользователем  чисел больше нуля равно {res}");