﻿/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
пример из 5 элементов:
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

получить все 8 чисел за одно нажатие Enter от пользователя.подсказка: использовать метод Split();
*/
Console.WriteLine("Введите массив");

string arr = Console.ReadLine()??"";
string[] nums = arr.Split (',');
int[] array = new int[8];

for (int i = 0; i < array.Length; i++)
{
    array[i] = int.Parse(nums[i]);

}
Console.Write( string.Join("\n", array));

//*ЧЕСТНО ГОВОРЯ, Я ВООБЩЕ НЕ ПОНЯЛ ЭТО ЗАДАНИЕ. С МАССИВАМИ ТЯЖЕЛО РАБОТАТЬ, НЕ ПОНИМАЮ КАК ИМИ ОПЕРИРОВАТЬ, ВВОДИТЬ, выводить и тд.