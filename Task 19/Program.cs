// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
Console.WriteLine("Введите пятизначное число");
string? arr = Console.ReadLine();

if (arr[0] == arr[4] && arr[1] == arr[3])
    {
        Console.WriteLine("Введенное число палиндром");
    }
    else
    {
        Console.WriteLine("Введенное число не палиндром");
    }
*/

Console.WriteLine("Введите пятизначное число");
int num = Convert.ToInt32(Console.ReadLine());
int num1 = num / 10000;
int num5 = num % 10;
int num2 = (num / 1000) % 10;
int num4 = (num % 100) / 10;
if (num1 == num5 && num2 == num4)
{
    Console.WriteLine("Введенное число палиндром");
}
else
{
    Console.WriteLine("Введенное число не палиндром");
}