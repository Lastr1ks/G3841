// Задача 2
// Напишите программу, которая на вход принимает два 
//числа и выдаёт, какое число большее, а какое меньшее.


//считываем данные с консоли
string? inputNum1 = Console.ReadLine();
string? inputNum2 = Console.ReadLine();

//проверяем чтобы данные были не пустыми
if (inputNum1 != null)
if (inputNum2 != null)
{
//парсим введенное число
    int number1 = int.Parse(inputNum1);
    int number2 = int.Parse(inputNum2);
    //cравниваем числа
    if (number1 < number2)
    {
        //Выводим результат
       int result = number2;
       Console.Write("MAX=");
       Console.Write(result);
    }
    else
    {
        //Выводим результат в консоль
    int result = number1;
       Console.Write("MAX=");
       Console.Write(result);
    }

}
