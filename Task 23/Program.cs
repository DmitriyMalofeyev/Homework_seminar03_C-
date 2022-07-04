// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.




//Console.WriteLine("Введите число");
//int num = Convert.ToInt32(Console.ReadLine());
//int[] squares = new int[num];
//for (int i = 1; i <= num; i++)
//{
//    squares[i-1] = i * i * i;
//    Console.WriteLine(squares[i-1]);
//}
/*
int i = 1;
while (i <= num)
{
    squares[i-1] = i * i * i;
    Console.WriteLine(squares[i-1]);
    i++;
}
*/

void calculate(int num)
{
    int[] A = new int[num];
    int i = 1;
    while (i <= num)
    {
        A[i-1] = i * i * i;
        Console.WriteLine(A[i-1]);
        i++;
    }
}



calculate(3);
calculate(5);