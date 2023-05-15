// Задача №20
// Напишите программу, которая принимает на вход
// координаты двух точек и находит расстояние между
// ними в 2D пространстве.

//Запрашиваем координаты точек
int x1 = ReadData("Введите координату x1");
int x2 = ReadData("Введите координату x2");
int y1 = ReadData("Введите координату y1");
int y2 = ReadData("Введите координату y2");

//Вычисляем длинну
double Length = CulcLen(x1, x2, y1, y2);

//Выводим результат в консоль
PrintData("Расстояние между точками =", Length);





//Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
//Метод выводит данные в консоль
void PrintData(string msg, double Length)
{
    Console.WriteLine(msg + Length);
}
//Метод находит расстояние между точками
double CulcLen(int x1, int x2, int y1, int y2)
{
    double res = 0;
    res = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
    return res;
}


