﻿// Задача №12
// Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли второе
// число кратным первому. Если второе число
// некратно первому, то программа выводит остаток от
// деления. 

//Вариант 1 

int num1 = int.Parse(Console.ReadLine()??"0");
int num2 = int.Parse(Console.ReadLine()??"0");
int res = num2%num1;
if (res==0)
{
    Console.WriteLine("Второе число кратно первому!");
}
else
{
    Console.WriteLine("Второе число НЕ кратно первому! " + res);
}