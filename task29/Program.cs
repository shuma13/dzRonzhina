// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

//6, 1, 33 -> [6, 1, 33]
int []array = new int[8];
void FillArray(int [] coll)
{
    int length = coll.Length;
    for (int i = 0; i < length; i++)
    {
        System.Console.WriteLine("введите значение для массива");
        int num = Convert.ToInt32(Console.ReadLine());
        coll[i] = num;
    }
}
FillArray(array);
foreach (var item in array)
{
   Console.Write(item +", "); 
}