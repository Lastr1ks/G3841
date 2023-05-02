// Задача 1
// Напишите программу, которая на вход принимает 2 числа
// и проверяет является ли первое число квадратом второго


//считываем данные с консоли 1 число
string? inputNum1 = Console.ReadLine();

//считываем данные с консоли 2 число
string? inputNum2 = Console.ReadLine();

//проверяем чтобы данные были не пустыми
if (inputNum1 != null && inputNum2 != null)
{
    //парсим введенное число
    int number1 = int.Parse(inputNum1);
    //парсим введенное число
    int number2 = int.Parse(inputNum2);

    if (number1 == number2 * number2)
    {
        Console.WriteLine("Первое число квадрат второго!");
    }
    else
    {
        Console.WriteLine("Первое число НЕ квадрат второго!");

    }
}