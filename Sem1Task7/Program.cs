//Программа принимает 3 значное число 
//и показывает последнее значение числа

//считываем данные с консоли
string? inputLine = Console.ReadLine();

//проверяем чтобы данные были не пустыми
if (inputLine != null) ;
//Парсим введенное число
int inputNumberA = int.Parse(inputLine);

int lastDigit = inputNumberA % 10;

Console.WriteLine(lastDigit);