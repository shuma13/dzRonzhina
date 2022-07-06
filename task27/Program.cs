// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

//452 -> 11

//82 -> 10

//9012 -> 12
int GetSumofNumbers(int num)
{
    int temp=0;
    while (num > 10)
    { 
        int c = num % 10;
        temp = temp + c;
        num = num / 10;
    }
    temp = temp + num;
    return temp;
}
System.Console.WriteLine("Введите число для нахождения суммы всех его чисел");
int number = Convert.ToInt32(Console.ReadLine());
int res = GetSumofNumbers(number);
System.Console.WriteLine(res);
