﻿// Задача №14
// Напишите программу, которая принимает на вход
// число и проверяет, кратно ли оно одновременно 7 и 23. 

// Вариант  1

int num = int.Parse(Console.ReadLine()??"0");
int res7 = num%7;
int res23 = num%23;
if ((res7==0)&&(res23==0))
//if (res7+res23==0)
{
    Console.WriteLine("Число одновременно кратно 7 и 23.");
}
else
{
    Console.WriteLine("Число НЕ кратно 7 и 23 одновременно.");
}