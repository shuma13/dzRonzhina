// Задача 19 3 семинар
Console.WriteLine("Введите number для проверки является ли оно полиндромом");
string some_number = Console.ReadLine();
char[]array = some_number.ToCharArray();
int count = array.Length;
int i = 0;
while (i<count/2)
{
    if(array[i] == array[count-1])
    {
        count= count-1;
        i++;
        System.Console.WriteLine("Заданное число является полиндромом");
    }
    else
    {
        System.Console.WriteLine("Заданное число не является полиндромом");
        break;
    }
}
