﻿// Почувствуй себя интерном
//  0. ======Вывести квадрат числа=======

// Вариант 1----------------------------------------------

// int Func(int x)
// {
//     return x * x;
// }
// int res = Func(5);
// Console.WriteLine(res);

// Вариант 2-------------------------------------------------

// int number = 2;

// int squareOfNumber = number * number;

// // System.Console.WriteLine(squareOfNumber);
// // System.Console.WriteLine(number * number);

//  1. ============= По двум заданным числам проверять является ли первое квадратом второго ==================

// int a = 3;
// int b = 9;
// if (b == a * a)
// {
//     System.Console.WriteLine("Число b является квадратом числа a");
// }
// else
// {
//     System.Console.WriteLine("Числа не являются квадратным воспроизведением друг друга");
// }
// if (a == b * b)
// {
//     System.Console.WriteLine("Число a является квадратом числа b");
// }
// else
// {
//     System.Console.WriteLine("Числа не являются квадратным воспроизведением друг друга");
// }


//  2.==================  Даны два числа. Показать большее и меньшее число ======================

// int NumberA = 6;
// int NumberB = 4;

// if (NumberA > NumberB)
// {
//     System.Console.WriteLine("NumberA Max" + "=" + NumberA);
//     System.Console.WriteLine("NumberB = Min" + NumberB);
// }
// else
// {
//     System.Console.WriteLine("NumberB = Max" + NumberB);
//     System.Console.WriteLine("NumberA = Min" + NumberA);
// }

//  3. ======= По заданному номеру дня недели вывести его название =======

// Вариант 1 -----------------------------------------------------------------------------------

// void Func(int x)
// {
//     string [] array = {"monday", "tuesday", "wednesday", "thursday", "friday", "saturday", "Sunday"};
//     Console.WriteLine(array[x - 1]); 
// }
// Func(1);

// Console.Write("Введите число от 1 до 7 и нажмите клавишу Enter: ");
// string DayCount = Console.ReadLine();

// Вариант 2 -------------------------------------------------------------------------------------

// if (DayCount == "1")
// {
//     System.Console.WriteLine("Monday");
// }
// if (DayCount == "2")
// {
//     System.Console.WriteLine("Tuesday");
// }
// if (DayCount == "3")
// {
//     System.Console.WriteLine("Wednesday");
// }
// if (DayCount == "4")
// {
//     System.Console.WriteLine("Thursday");
// }
// if (DayCount == "5")
// {
//     System.Console.WriteLine("Friday");
// }
// if (DayCount == "6")
// {
//     System.Console.WriteLine("Saturday");
// }
// if (DayCount == "7")
// {
//     System.Console.WriteLine("Sunday");
// }

//  4. Найти максимальное из трех чисел

// int z = 4;
// int b = 4;
// int c = 4;
// int max = z;

// if (b > max) max = b;
// if (c > max) max = c;

// System.Console.WriteLine("max = " + max);

//  5. Написать программу вычисления значения функции y=f(a)
//  6. =======Выяснить является ли число чётным========

// void Func(int a)
// {
//     if(a % 2 == 0)
//     {
//         Console.WriteLine("Является четным");
//     }
//     else
//     {
//         Console.WriteLine("Не является четным");
//     }
// }
// Func(5);


//  7. =======Показать числа от -N до N========

// int [] arrayA = new int [10];

// void CreateArray(int [] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(-10, 11);
//     }
// }

// void ShowArray(int [] array)
// {
//     for(int ind = 0; ind < array.Length; ind++)
//     {
//         Console.Write($"{arrayA[ind]} ");
//     }
// }

// CreateArray(arrayA);
// ShowArray(arrayA);

//  8. =========Показать четные числа от 1 до N=========

// int [] arrayA = new int [10];

// void CreateArray(int [] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(1, 21);
//     }
// }

// void ShowArray(int [] array)
// {
//     for(int ind = 0; ind < array.Length; ind++)
//     {
//         Console.Write($"{arrayA[ind]} ");
//     }
// }

// void ShowEven(int [] array)
// {
//     for(int index = 0; index < array.Length; index++)
//     if(arrayA[index] % 2 == 0)
//     {
//         Console.Write($"{arrayA[index]} ");
//     }
// }

// CreateArray(arrayA);
// ShowArray(arrayA);
// Console.WriteLine();
// ShowEven(arrayA);

// Вариант 2 -----------------------------------------------------------------------------

// int N = new Random().Next(1, 50);
// System.Console.WriteLine(N);
// System.Console.WriteLine();
// for (int a = 1; a <= N; a++)
// {
//     if (a % 2 == 0)
//     {
//         System.Console.WriteLine(a + " ");
//     }
// }

//  9. =====Показать последнюю цифру трёхзначного числа======

// int LastNumber(int arg)
// {
//     arg = arg % 10;
//     return arg;
// }
// int ans = LastNumber(251);
// Console.WriteLine(ans);

// 10. =========Показать вторую цифру трёхзначного числа========

// int SecNumber(int arg)
// {
//     arg = arg / 10 % 10;
//     return arg;
// }
// int ans = SecNumber(298);
// Console.WriteLine(ans);

// 11. =========Дано число из отрезка [10, 99]. Показать наибольшую цифру числа=======

// void MaxNum(int arg)
// {
//     int a = 0;
//     int b = 0;
//     a = arg / 10;
//     b = arg % 10;
//     if(a > b)
//     {
//         Console.WriteLine(a);
//     }
//     else
//     {
//         Console.WriteLine(b);
//     }
// }

// int CreateNum()
// {
//     int ranNum = new Random().Next(10, 100);
//     return ranNum;
// }

// int number = CreateNum();
// Console.WriteLine(number);
// MaxNum(number);

// 12. ======Удалить вторую цифру трёхзначного числа=========

// void DeleteSecNumber(int arg)
// {
//     int a = arg / 100;
//     int b = arg % 10;
//     int c = a * 10 + b;
//     Console.WriteLine(c);
// }

// DeleteSecNumber(371);

// 13. ========Выяснить, кратно ли число заданному, если нет, вывести остаток.=======

// int CreateNum()
// {
//     int ranNum = new Random().Next(10, 100);
//     return ranNum;
// }

// int CreateDev()
// {
//     int devNum = new Random().Next(2, 10);
//     return devNum;
// }

// int firstNum = CreateNum();
// int secondNum = CreateDev();

// if(firstNum % secondNum == 0)
// {
//     Console.WriteLine($"Число {firstNum} кратно {secondNum}");
// }
// else
// {
//     int residual = firstNum % secondNum;
//     Console.WriteLine($"Остаток деления {firstNum} на {secondNum} равен {residual}");
// }

// 14. Найти третью цифру числа или сообщить, что её нет

// int RandomNum()
// {
//     int x = new Random().Next(1, 1000);
//     return x;
// }

// int number = RandomNum();

// void FindThirdNum(int arg)
// {
//     if((number / 100) >= 1)
//     {
//         int y = number % 10;
//         Console.WriteLine($"Третьей цифрой числа {number} является {y}");
//     }
//     else
//     {
//         Console.WriteLine("Третьей цифры в числе нет!");
//     }
// }
// FindThirdNum(number);

// Почувствуй себя джуном

// 15. =========Дано число. Проверить кратно ли оно 7 и 23

// int Number(int num)
// {
//     int result = 0;
//     if(num % 7 == 0)
//     {
//         if(num % 23 == 0) result = 1; 
//     }
//     return result;
// }
// int ans = Number(160);
// Console.WriteLine(ans);

// 16. ======Дано число обозначающее день недели. Выяснить является номер недели выходным днём



// 17. =====По двум заданным числам проверять является ли одно квадратом другого

// int Func17(int a, int b)
// {
//     int res = 0;
//     if (a > b)
//     {
//        if (a == b * b) res = 1;
//     }
//     else
//     {
//       if (b == a * a) res = 2;  

//     }
//     return res;
// }
// int firstNum = 5;
// int secondNum = 25;
// int ans = Func17(firstNum, secondNum);

// void PrintFunc(int arg)
// {
//     if (ans == 0) Console.WriteLine("ни одно число не является квадратом другого");
//     if (ans == 1) Console.WriteLine($"{firstNum} является квадратом {secondNum}");
//     if (ans == 2) Console.WriteLine($"{secondNum} является квадратом {firstNum}");
// }
// PrintFunc(ans);


// 18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y

// bool Func18(bool x, bool y)
// {
//     bool output = false;
//     if(!(x & y) == !x ^ !y)
//     {
//         output = true;
//     }
//     return output;
// }

// bool ans = Func18(false, false);
// Console.WriteLine(ans);

// 19. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
// 20. Ввести номер четверти, показать диапазоны для возможных координат
// 21. Программа проверяет пятизначное число на палиндромом.
// 22. Найти расстояние между точками в пространстве 2D/3D

// Почувствуй себя мидлом
// 23. Показать таблицу квадратов чисел от 1 до N 
// 24. Найти кубы чисел от 1 до N
// 25. Найти сумму чисел от 1 до А
// 26. Возведите число А в натуральную степень B используя цикл
// 27. Определить количество цифр в числе
// 28. Подсчитать сумму цифр в числе
// 29. Написать программу вычисления произведения чисел от 1 до N
// 30. Показать кубы чисел, заканчивающихся на четную цифру

// Почувствуй себя сеньором
// 31. Задать массив из 8 элементов и вывести их на экран 
// 32. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран 
// 33. Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива
// 34. Написать программу замену элементов массива на противоположные
// 35. Определить, присутствует ли в заданном массиве, некоторое число 
// 36. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
// 37. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
// 38. Найти сумму чисел одномерного массива стоящих на нечетной позиции
// 39. Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// 40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

// Почувствуй себя лидом
// 41. Выяснить являются ли три числа сторонами треугольника 
// 42. Определить сколько чисел больше 0 введено с клавиатуры
// 43. Написать программу преобразования десятичного числа в двоичное
// 44. Найти точку пересечения двух прямых заданных уравнением y=kx+b, а1 k1 и а2 и k2 заданы
// 45. Показать числа Фибоначчи
// 46. Написать программу масштабирования фигуры
// 47. Написать программу копирования массива