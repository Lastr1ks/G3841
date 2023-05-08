﻿// №10 Напишите программу, которая принимает на вход трёхзначное число и на выходе
// показывает вторую цифру этого числа. 

//Проверка на 0
int number = int.Parse(Console.ReadLine() ?? "0");
//Проверка на 3x значность
if ((number < 1000) && (number >= 100))
{
    //Убираем последнее число
    int result = number / 10;
    //Убираем первое число
    result = result % 10;
    //Вывод в консоль
    Console.WriteLine(result);
}
else
{
    //Вывод в консоль
    Console.WriteLine("Число не является трехзначным!");
}