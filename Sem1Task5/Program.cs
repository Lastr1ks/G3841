//Программа которая из введенного числа N показывает числа от -N до N

//считываем данные с консоли
string? inputLine = Console.ReadLine();

//проверяем чтобы данные были не пустыми
if (inputLine != null) ;
//Парсим введенное число
int inputNumberA = int.Parse(inputLine);
//Выводим промежуточное значение
int inputNumberB = inputNumberA * (-1);
//Выходное значение
string outNumLine = string.Empty;
//Цикл while
while (inputNumberB <= inputNumberA)
{
    outNumLine = outNumLine + inputNumberB + ",";
    inputNumberB = inputNumberB + 1;
}
Console.WriteLine(outNumLine);
