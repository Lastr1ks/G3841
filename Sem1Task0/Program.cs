// Задача 0
// Напишите программу, которая на вход принимает число
// и выдает его квадрат (число умноженное на само себя)

//считываем данные с консоли
string? inputNum = Console.ReadLine();

//проверяем чтобы данные были не пустыми
if (inputNum != null)
{
    //парсим введенное число
    int number = int.Parse(inputNum);
    //находим квадрат числа
    int result = (int)Math.Pow(number, 2);

    //выводим данные в консоль
    Console.WriteLine(result);
}