// Задача №22
// Напишите программу, которая принимает на вход
// число (N) и выдаёт таблицу квадратов чисел от 1 до
// N.

// Запрашиваем число и степень
int num = ReadData("Введите число");
int pow = ReadData("Введите степень");

// Вызываем метод
string res1 = LineBuilder(num, 1);
string res2 = LineBuilder(num, pow);

// Выводим результат
PrintData(res1, res2);

//Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
//Метод выводит данные в консоль
void PrintData(string result1, string result2)
{
    Console.WriteLine(result1);
    Console.WriteLine(result2);
}
//Метод выводит числа в нужной степени
string LineBuilder(int number, int pow)
{
    string res = string.Empty;
    for (int i = 1; i <= number; i++)
    {
         res+= Math.Pow(i, pow).ToString()+"\t";
    }
  
    return res;
}


