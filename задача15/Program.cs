/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine("Введите число дня недели:");
int number = int.Parse(Console.ReadLine());

switch (number)
{
    case 1:
    case 2:
    case 3:
    case 4:
    case 5:
        Console.WriteLine($"{number} -> нет");
        break;
    case 6:
    case 7:
        Console.WriteLine($"{number} -> да");
        break;
    default:
        Console.WriteLine("Ввели число не соответствующее дню недели");
        break;

}