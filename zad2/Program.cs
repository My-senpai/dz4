/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
*/

System.Console.WriteLine("Введите число");
var num = int.Parse(Console.ReadLine()??"");
var sum = 0;
var c = num;

while (c > 0)
{
    sum = sum + c % 10;
    c = c / 10;
} 
System.Console.WriteLine(sum);


