// Почувствуй себя интерном
//  0. ======Вывести квадрат числа=======

// Вариант 1----------------------------------------------

// int Func(int x)
// {
//     return x * x;
// }
// int res = Func(100);
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


// Вариант 2 -------------------------------------------------------------------------------------


// Console.Write("Введите число от 1 до 7 и нажмите клавишу Enter: ");
// string DayCount = Console.ReadLine();

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

// int a = 4;
// int b = 4;
// int c = 4;
// int max = a;

// if (b > max) max = b;
// if (c > max) max = c;

// System.Console.WriteLine("max = " + max);

//  5. Написать программу вычисления значения функции y=f(a)

// int y (int a)
// {
//     return a*a-5;
// } 
// int c = y(6);
// System.Console.WriteLine(c);

//  6. ============ Выяснить является ли число чётным     ==================

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


// //  7. =======Показать числа от -N до N========

// int [] arrayA = new int [10]; // объявил массив

// void CreateArray(int [] array) // создает массив
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(-100, 100);
//     }
// }

// void ShowArray(int [] array) // выводит массив
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
//         Console.Write($"{arrayA[index]}  " );
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
//         System.Console.Write(a + " ");
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
// // MaxNum(number);

// // 12. ====== Удалить вторую цифру трёхзначного числа =========

// int DeleteSecNumber(int arg)
// {
//     int a = arg / 100;
//     int b = arg % 10;
//     int c = a * 10 + b;
//     return c;
// }

// int d = DeleteSecNumber(371);
// System.Console.WriteLine(d);

// if (74 == DeleteSecNumber(458))
// {
//     System.Console.WriteLine("Верно");
// }
// else
// {
//     System.Console.WriteLine("Не верно");
// }

// Вариант 2 ----------------------------------------------------

// int n = 789;
// int delTwo(int n)
// {
//     int num1 = n / 100;
//     int num3 = n % 10;
//     return num1 * 10 + num3;
// }
// Console.WriteLine(delTwo(n));

// 13. ======== Выяснить, кратно ли число заданному, если нет, вывести остаток. =======

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

// Вариант 2 -------------------------------------------------------------

// int a = 80;
// int b = 20;
// System.Console.WriteLine(a);
// System.Console.WriteLine(b);
// int result = a / b;
// if (a % b ==0)
// {
//     System.Console.WriteLine("Кратно");
// }
// else
// {
//     System.Console.WriteLine("Остаток = " + a % b);
// }

// 14. Найти третью цифру числа или сообщить, что её нет 

// int a = new Random().Next(10,1000);
// System.Console.WriteLine(a);

// if (a < 100)
// {
//     System.Console.WriteLine("Третьей цифры нет");
// }
// else
// {
//     int b = a % 10;
//     System.Console.WriteLine(b);
// }


// Вариант 2 --------------------------------------------------------------------------

// int RandomNum()
// {
//     int x = new Random().Next(1, 1000);
//     return x;
// }
// int number = RandomNum();
// System.Console.WriteLine(number);

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
// FindThirdNum(number); // ПОЧЕМУ ТАК ???

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

//  Вариант 2 ---------------------------------------------------------

// int Number(int num)
// {
//     int result = 0;
//     if (num % 7 == 0 & num % 23 == 0)
//     {
//         result = 1;
//         return result;
//     }
//     else
//     {
//         return result;
//     }
// }

// int ans = Number(161);
// Console.WriteLine(ans);

//  Варинт 3 -----------------------------------------

// bool Number(int num)
// {
//     return (num % 7 == 0 & num % 23 == 0);
// }
// System.Console.WriteLine(Number(161));


// 16. ======Дано число обозначающее день недели. Выяснить является номер недели выходным днём


// Console.Write("Введите число от 1 до 7 и нажмите клавишу Enter: ");
// int yourDay = int.Parse(Console.ReadLine()); // вводные данные 

// bool dayNum(int num) // выводит тип данных (true or false) + название метода (аргумент) 
// {
//     return (num == 6 | num == 7); // возвращает результат аргумента
// }
// int a = 1; // просто счетчик
// while (a > 0)
// {
//     if (yourDay >= 1 & yourDay <= 7)
//     {
//         System.Console.WriteLine(dayNum(yourDay)); // покажи как ты использовал метод с вводными данными
//         break;
//         a++;
//     }
//     else
//     {
//         System.Console.WriteLine("Вы ввели не корректное число");
//         Console.Write("Введите число от 1 до 7 и нажмите клавишу Enter: ");
//         yourDay = int.Parse(Console.ReadLine()); // вводные данные
//         a++;
//     }
// }

// Вариант 2 ------------------------------------------------------------------------------

// bool NumDay(int num)
// {
//     return (num == 6 | num ==7);
// }

// Console.Write("Введите число от 1 до 7: ");
// for(int a = 1; a > 0; a++)
// {
//     int dayNum = int.Parse(Console.ReadLine());
//     if(dayNum > 0 & dayNum < 8)
//     {
//        Console.WriteLine(NumDay(dayNum));
//        break;
//     }
//     else
//     {
//         Console.WriteLine("Введите верное число");
//     }
// }

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

// Вариант 2 ------------------------------------------------------------

// bool result(int a, int b)
// {
//     return (a == bb | b == aa);
// }

// Console.WriteLine(result(5, 25));


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
// Console.WriteLine(ans    );

// 19. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
// 20. Ввести номер четверти, показать диапазоны для возможных координат
// 21. Программа проверяет пятизначное число на палиндромом.

// 12321 


// int a = new Random().Next (10000,100000);

// int firstNum = a / 10000; // 1
// int secondNum = a /1000 % 10; // 2
// int fourthNum = a % 100 / 10; // 2
// int fifthNum = a % 10; // 1

// if (firstNum == fifthNum & secondNum == fourthNum)
// {
//     System.Console.WriteLine($"Число {a} палиндром");
// }
// else
// {
//     System.Console.WriteLine($"Число {a} не палиндром");
// }
// System.Console.WriteLine();


// bool IsPolindrome(int N)
// {
//     string C = Convert.ToString(N);
//     int N1 = C[0];
//     int N2 = C[1];
//     int N3 = C[3];
//     int N4 = C[4];
//     if (N1 == N4 & N2 == N3)
//     {
//         return true;
//     }
//     else
//     {
//         return false;
//     }
// }

// if (IsPolindrome(12321)) Console.WriteLine("Палиндром.");
// else Console.WriteLine("Не палиндром.");



// 22. Найти расстояние между точками в пространстве 2D/3D

// double GetLengthBetween(double x1, double y1, double z1, double x2, double y2, double z2) // 22
// {
//     double x = Math.Abs(x1 - x2);
//     double y = Math.Abs(y1 - y2);
//     double z = Math.Abs(z1 - z2);
//     double L = Math.Sqrt(x * x + y * y + z * z);
//     return L;
// }

// double L = GetLengthBetween(0, 0, 0, 1, 2, 2);
// Console.WriteLine(L);


// Почувствуй себя мидлом
// 23. Показать таблицу квадратов чисел от 1 до N 
// 24. Найти кубы чисел от 1 до N

// Вариант 1 (не решил)-------------------------------

// int a = 1;
// int N = 10;

// for ( N<=10; N++);
// {
//     System.Console.WriteLine(N);
// }

// Вариант 1.1

// int a = 1;
// int n = 10;
// for(a=1;a<=n;a++)
// {
//     Console.WriteLine(a*a*a);
// }

// Вариант 2 ---------------------------------

// int a = 1;
// int N = 10;
// while(a <= N)
// {
//     int b = a*a*a;
//     System.Console.WriteLine(b);
//     a++;
// }



// 25. Найти сумму чисел от 1 до А
// 26. Возведите число А в натуральную степень B используя цикл

// int toPower(int number, int degree)
// {
//     int result = 1;
//     for (int i = 1; i <= degree; i++)
//     {
//         result = result * number;
//     }
//     return result;

// }

// if (8 == toPower(2, 3))
// {
//     System.Console.WriteLine("Работает корректно");
// }
// else
// {
//     System.Console.WriteLine("Работает не корректно");
// }

// 27. Определить количество цифр в числе
// 28. Подсчитать сумму цифр в числе

// Не решил !!!! ________________________________________

// int a = new Random().Next (100,100000);
// int b = 0; 
// while (Num > 0);
// {
//     b = a/10;
//     Nun = b;

// }
// System.Console.WriteLine(a);



// 29. Написать программу вычисления произведения чисел от 1 до N
// 30. Показать кубы чисел, заканчивающихся на четную цифру


// int n = 10;
// for(int a=1;a<=n;a++)
// {
//     int result = a*a*a;
//     if (result %2 == 0)
//     {
//         System.Console.WriteLine (result);
//     }
// }


// Почувствуй себя сеньором
// 31. Задать массив из 8 элементов и вывести их на экран 
// 32. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран 

// int[] Array = new int [8];

// for (int i = 0; i <= Array.Length; i++)
// {
//     System.Console.WriteLine(Array [i]);

// }

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