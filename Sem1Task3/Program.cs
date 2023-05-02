﻿//считываем данные с консоли
string? inputLine = Console.ReadLine();

//проверяем чтобы данные были не пустыми
if (inputLine != null)
{
    //Вариант 1
    // //создаем массив с днями недели
    // string[] dayOfWeek = new string[7];
    // dayOfWeek[0] = "Понедельник";
    // dayOfWeek[1] = "Вторник";
    // dayOfWeek[2] = "Среда";
    // dayOfWeek[3] = "Четверг";
    // dayOfWeek[4] = "Пятница";
    // dayOfWeek[5] = "Суббота";
    // dayOfWeek[6] = "Воскресенье";
    // //Парсим введенное число
    // int inputNumber = int.Parse(inputLine);
    // //Находим название недели по введенному номеру
    // string outDayOfWeek = dayOfWeek[inputNumber - 1];
    // //Выводим данные в консоль
    // Console.WriteLine(outDayOfWeek);

//Вариант 2
int inputNumber = int.Parse(inputLine);
// string outDayOfWeek = string.Empty;
// switch (inputNumber)
// {
//     case 1: outDayOfWeek = "Понедельник"; break;
//     case 2: outDayOfWeek = "Вторник"; break;
//     case 3: outDayOfWeek = "Среда"; break;
//     case 4: outDayOfWeek = "Четверг"; break;
//     case 5: outDayOfWeek = "Пятница"; break;
//     case 6: outDayOfWeek = "Суббота"; break;
//     case 7: outDayOfWeek = "Воскресенье"; break;
//     default: outDayOfWeek = "Это не день недели!"; break;
// }
// Console.WriteLine(outDayOfWeek);


//Вариант 3
string outDayOfWeek = System.Globalization.CultureInfo.GetCultureInfo("ru-RU").DateTimeFormat.GetDayName((DayOfWeek)Enum.GetValues(typeof(DayOfWeek)).GetValue(inputNumber));
Console.WriteLine(outDayOfWeek);

}
