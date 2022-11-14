/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
 Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/

System.Console.WriteLine("Введите число на консоль: ");
int number = int.Parse(Console.ReadLine()??"");

string GetNumber(int number)
{
    if (number<=1)
    {
        return number.ToString();
    }
    else return number+","+ GetNumber(number-1);
}

System.Console.WriteLine(GetNumber(number));