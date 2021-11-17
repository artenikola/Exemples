// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задать массив из 8 элементов и вывести их на экран 

// int [] array = new int [10]; // будет массив - название массива - сколько элементов будет в массиве
// System.Console.WriteLine(array[0]);
// System.Console.WriteLine();
// for (int i = 1; i < 8; i++) 
// {
//  System.Console.WriteLine(i);   
// }

// 33. Задать массив из 12 элементов, заполненных числами из [-9,9]. Найти сумму положительных/отрицательных элементов массива
// 34. Написать программу замену элементов массива на противоположные
// 35. Определить, присутствует ли в заданном массиве, некоторое число 
// 36. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
// 37. В одномерном массиве из 123 элементов найти количество элементов из отрезка [10,99]
// 38. Найти сумму чисел одномерного массива стоящих на нечетной позиции
// 39. Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// 40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом


// Задача 33

// int[] array = new int[12];
// int SumOtr = 0;
// int SumPol = 0;
// for (int i = 0; i < 12; i++)
// {
//     array[i] = new Random().Next(-9, 10);
//     if (array[i] <= 0)
//     {
//         SumOtr = SumOtr + array[i];
//     }
//     else
//     {
//         SumPol = SumPol + array[i];
//     }
// }
// for (int i = 0; i < 12; i++)
// {
//     System.Console.Write(array[i] + " ");
// }
// System.Console.WriteLine();
// System.Console.WriteLine(SumPol);
// System.Console.WriteLine(SumOtr);

// Задача 35 Определить, присутствует ли в заданном массиве, некоторое число 

// System.Console.WriteLine("Дай от -9 до 10");
// int number = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[12];

// for (int i = 0; i < 12; i++)
// {
//     array[i] = new Random().Next(-9, 10);
//     if (number == array[i])
//     {
//         System.Console.WriteLine("Такое число есть в массиве");
//     }
//     else
//     {
//         System.Console.WriteLine("Такого числа нет в массиве");
//     }
// }

// Задача 37

// int[] array = new int[123];

// for (int i = 0; i < 122; i++)
// {
//     array[i] = new Random().Next(0, 20);
//     System.Console.Write(array[i] + " "); // заполнили массив и вывели на экран
// }

// int count = 0;

// for (int i = 0; i < 122; i++)
// {
//     if (array[i] > 9 & array[i] < 100)
//     {
//         count++;
//     }
// }
// System.Console.WriteLine(" ");

// System.Console.WriteLine(count);

// Вариант 2 ----------------------

// int GetCount(int[] array, int LeftBound, int RighrBound)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] >= LeftBound && array[i] <= RighrBound)
//         {
//             count = count + 1;
//         }
//     }
//     return count;
// }
// System.Console.WriteLine(GetCount(new int[]{1,16,24,54,87,25,31}, 20, 35));


// Задача 39. Найти произведение пар чисел в массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.

// int[] array = new int[6];

// for (int i = 0; i < 5; i++)
// {
//     array[i] = new Random().Next(0, 20);
//     System.Console.Write(array[i] + " "); // заполнили массив и вывели на экран
// }

// 0 1 2 3 4 5
// 5 4 3 2 1 0

// int first = array [0];
// int last = array [5];

// for (int i = 0; i < 5; i++)
// {
//     i = first * last

// }

// 18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y

// bool Func18(bool x, bool y)
// {
//     return (!(x | y) == (!x & !y));
// }
// bool ans = Func18(false, false);
// Console.WriteLine(ans);
// ans = Func18(true, false);
// Console.WriteLine(ans);
// ans = Func18(false, true);
// Console.WriteLine(ans);
// ans = Func18(true, true);
// Console.WriteLine(ans);