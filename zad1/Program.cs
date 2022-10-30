/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/
System.Console.WriteLine("Введите число А: ");
var A = int.Parse(Console.ReadLine()??"");

System.Console.WriteLine("Введите число B: ");
var B = int.Parse(Console.ReadLine()??"");

var C = Math.Pow(A, B);
System.Console.WriteLine($"число {A} в степени {B} будет равно - {C}");




