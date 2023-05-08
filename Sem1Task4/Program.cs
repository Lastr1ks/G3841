// Задача 4
// Напишите программу, которая на вход принимает три 
//числа и выдаёт, максимальное из этих чисел.


//считываем данные с консоли
string? inputNum1 = Console.ReadLine();
string? inputNum2 = Console.ReadLine();
string? inputNum3 = Console.ReadLine();

//проверяем чтобы данные были не пустыми
if (inputNum1 != null)
    if (inputNum2 != null)
        if (inputNum3 != null)
        {
            //парсим введенное число
            int number1 = int.Parse(inputNum1);
            int number2 = int.Parse(inputNum2);
            int number3 = int.Parse(inputNum3);
            //cравниваем числа
            if (number1 < number2)
            {
                //cравниваем числа
                if (number2 < number3)
                {
                    //Выводим результат в консоль
                    int result = number3;
                    Console.Write("MAX=");
                    Console.Write(result);
                }
                else
                {
                    //Выводим результат в консоль
                    int result = number2;
                    Console.Write("MAX=");
                    Console.Write(result);
                }
            }
            else
            {
                //cравниваем числа
                if (number1 < number3)
                {
                    //Выводим результат в консоль
                    int result = number3;
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

        }