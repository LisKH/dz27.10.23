﻿//стр 34 № 4
//Console.WriteLine("Введите очередное число");
//double n = Convert.ToDouble(Console.ReadLine());
//double a, b, c;
//a = 0;
//b = 0;
//c = 1;
//for (int i = 1; i <= n; i++)
//{
//    a = a + Math.Cos(i);
//    b = b + Math.Sin(i);
//    c = c * (a / b);
//}
//Console.WriteLine($"Выражение равно ={c}");

//стр 21 № 25
//Console.WriteLine("введите одну из величин первого прямоугольного паралепипеда");
//double a = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("введите одну из величин первого прямоугольного паралепипеда");
//double b = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("введите одну из величин первого прямоугольного паралепипеда");
//double c = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("введите одну из величин второго прямоугольного паралепипеда");
//double qa = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("введите одну из величин второго прямоугольного паралепипеда");
//double qb = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("введите одну из величин второго прямоугольного паралепипеда");
//double qc = Convert.ToDouble(Console.ReadLine());
//double q = 0;
//double y = 0;
//q += a * b * c;
//y += qa * qb * qc;
//if (q > y)
//    Console.WriteLine("первый паралепипед больше");
//else
//    Console.WriteLine("второй паралепипед больше");

//стр 34 № 11
//double a , b;
//b = 1 + Math.Sin(0.1);
//for (double i = 0.2; i <= 10; i += 0.1 )
//{
//    a = 1 + Math.Sin(i);
//    b = b * a;
//}
//Console.WriteLine($"Выражение равно ={c}");

//стр 39 № 22
//double summa = 0;
//Console.WriteLine("Введите число окончания");
//int b = Convert.ToInt32(Console.ReadLine());
//while (b > 0)
//{
//    Console.WriteLine("Введите очередное число последовательности d=");
//    double c = Convert.ToDouble(Console.ReadLine());
//    double a = c % 10;
//    if (a / b == 1)
//        summa += c;
//    else
//        Console.WriteLine("число не оканчивается на заданное");
//    Console.WriteLine("Продолжить ввод? Y/N");
//    if (Console.ReadLine() == "N")
//        break;
//}
//Console.WriteLine($"Сумма последовательности равна = {summa}");
