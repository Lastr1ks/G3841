// №13 Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет. 

//Проверка длинны числа и запись его в Length
string orgNumber=Console.ReadLine();
int Length = orgNumber.Length;
//Проверка на  0 и преобразование string в int
int number = int.Parse(orgNumber??"0");



//Проверка на более 2х значность
if (number >= 100)
{
    //Убираем числа после 3 цифры
    int result = (int)(number / Math.Pow(10, Length-3));
    //Убираем числа до 3 цифры
    result = result % 10;
    //Вывод в консоль
    Console.WriteLine(result);
}
else
{
    //Вывод в консоль
    Console.WriteLine("Третьей цифры нет");
}