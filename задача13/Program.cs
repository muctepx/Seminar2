/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

int ReadData(string line)
{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

char ThirdNumChar(string inputNumber)
{
    char[] simbols = inputNumber.ToCharArray();
    return simbols[2];
}


void PrintData(string prefix, string value)
{
    Console.WriteLine(prefix + value);
}


int number = ReadData("Введите число: ");
if (number < 100)
{
    PrintData("Такой цифры нет", "");
}
else
{
    char thirdSimbol = ThirdNumChar(number.ToString());
    PrintData($"{number} -> ", thirdSimbol.ToString());
}