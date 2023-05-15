// Задача №11
// Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа. 

//Вариант  1
// System.Random numSintezator = new System.Random();

// char[] digits = numSintezator.Next(100,1000).ToString().ToCharArray();
// Console.WriteLine(digits);
// int digit1 = (int)digits[0]-48;
// int digit2 = (int)digits[1]-48;
// int digit3 = (int)digits[2]-48;
// Console.WriteLine(digit1+" "+ digit3);

//Вариант 2
System.Random numSintezator = new System.Random();

int num = numSintezator.Next(100,1000);
Console.WriteLine(num);
int digit1 = num/100;
int digit3 = num%10;
Console.WriteLine(digit1+""+ digit3);
//Console.WriteLine(digit1*10 + digit3);