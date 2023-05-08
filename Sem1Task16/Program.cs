// Задача №16
// Напишите программу, которая принимает на вход
// два числа и проверяет, является ли одно число
// квадратом другого. 


double number1 = double.Parse(Console.ReadLine()??"0");
double number2 = double.Parse(Console.ReadLine()??"0");

double result1 = Math.Pow(number1, 2);
double result2 = Math.Pow(number2, 2);

if ((result1 == number2)||(result2 == number1))
{
    Console.WriteLine("Одно число является квадратом другого.");
}
else
{
    Console.WriteLine("Одно число НЕ является квадратом другого.");
}