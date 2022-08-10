Console.Clear();

// Задание
// Пример
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8 
// 918 -> 1

Console.WriteLine("Введите трехзначное число, а я покажу 2 цифру этого числа");

int number = Convert.ToInt32 (Console.ReadLine());

if (Math.Abs(number) > 99 && Math.Abs(number) < 1000)
{
    number = Math.Abs(number) / 10 % 10;
    Console.WriteLine("Средняя цифра: " + number);
}
else
{
    Console.WriteLine("Необходимо указать трёхзначное число, попробуйте еще раз");
}


Console.WriteLine(" ");

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число, а я покажу третью цифру этого числа или сообщу, если ее нет");
int number1 = Convert.ToInt32 (Console.ReadLine());

int max = 1000;
int min = max / 10 - 1;
int num1 = 1;

if (Math.Abs(number) < 100)
    {
        Console.Write("Третьей цифры нет");
    }

while (Math.Abs(number1) > 99)
{
    if (Math.Abs(number1) > min && Math.Abs(number1) < max)
    {
        number1 = Math.Abs(number1) / num1 % 10;
        Console.WriteLine("Третья цифра: " + number1);
    }
    else
    {
        min = min * 10; max = max * 10;
        num1 = num1 * 10;
    }
}

Console.WriteLine(" ");

// // Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// // 6 -> да 
// // 7 -> да 
// // 1 -> нет

Console.Write("Введите номер дня недели (пн-1, вт-2 и т.д), а я собщу является ли он выходным: ");

int w_day = Convert.ToInt32(Console.ReadLine());

if (w_day < 6 && w_day > 0) Console.Write("Нет");
if (w_day > 5 && w_day < 8) Console.Write("Да");
if (w_day > 7 || w_day < 1) Console.Write("Дня недели не существует");