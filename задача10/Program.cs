/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

Console.WriteLine("Введите трехзначное число: ");
string numberStr = Console.ReadLine();
int number = int.Parse(numberStr);
if (99 < number && number < 1000)
{
    int result = (number % 100) / 10;
    Console.WriteLine ($"{number} -> {result}");
}
else Console.WriteLine ("Вы ввели не трехзначное число");