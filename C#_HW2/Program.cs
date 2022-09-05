//Напишите программу, которая принимает на вход трёхзначное число и 
//на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

int number = new Random().Next(100, 1000); //456 -> 5
int firstDigit = number /10;
int secondDigit = firstDigit % 10; 
Console.WriteLine($"Вторая цифра из числа {number} - это {secondDigit}");

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или 
//сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.WriteLine("Введите цифру ");
string? number = Convert.ToString(Console.ReadLine());
if(number.Length > 3)
{
    Console.WriteLine($"Третья цифра {number[2]}");
}
else Console.WriteLine("Третьей цифры нет");

//Задача 15: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.WriteLine("Введите номер дня недели ");
int numberDay = Convert.ToInt32(Console.ReadLine());
if(numberDay < 6)
{
    Console.WriteLine($"{numberDay}- это будний день");
}
else Console.WriteLine($"{numberDay}- это выходной"); 

