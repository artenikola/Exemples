// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// 31. Задать массив из 8 элементов и вывести их на экран 
// 32. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран 
// 33. Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива
// 34. Написать программу замену элементов массива на противоположные
// 35. Определить, присутствует ли в заданном массиве, некоторое число 
// 36. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетныхчетных чисел
// 37. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
// 38. Найти сумму чисел одномерного массива стоящих на нечетной позиции
// 39. Найти произведение пар чисел в массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// 40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
// 41. Выяснить являются ли три числа сторонами треугольника 
// 42. Определить сколько чисел больше 0 введено с клавиатуры
// 43. Написать программу преобразования десятичного числа в двоичное
// 44. Найти точку пересечения двух прямых заданных уравнением y=kx+b, а1 k1 и а2 и k2 заданы
// 45. Показать числа Фибоначчи
// 46. Написать программу масштабирования фигуры
// 47. Написать программу копирования массива

// 38. Найти сумму чисел одномерного массива стоящих на нечетной позиции

// 1. Создать массив 2. Заполнить массив 3. Вычислить сумму чисел

// int[] array = new int[10];

// // int[] CreateArray(int len)
// // {
// //     return new int[len];
// // } 

// int[] FillArray(int[] Arr) // метод а в круглых скобках тело метода
// {
//     for (int i = 0; i < Arr.Length; i++)
//     {
//         Arr[i] = new Random().Next(1, 10);
//     }
//     return Arr;
// }

// array = FillArray(array);

// void PrintArray(int[] A)
// {
//     for (int i = 0; i < A.Length; i++)
//     {
//         System.Console.WriteLine(A[i]);
//     }
// }

// PrintArray(array);

// int SumArray(int[] B)
// {
//     int Sum = 0;
//     for (int i = 1; i < B.Length; i++)
//     {
//         if (i % 2 != 0)
//         {
//             Sum = Sum + B[i];
//         }
//     }
//     return Sum;
// }

// int result = SumArray(array);
// System.Console.WriteLine(result);

// 39. Найти произведение пар чисел в массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.

// int [] array = new int [6]; // создали массив с нулями

// int [] GetArray (int [] A)
// {
//     for(int i = 0; i<A.Length; i++)
//     {
//         A [i] = new Random().Next(1,10); // наполнили массив числами от 10 до 99
//     }
//     return A;
// }

// void PrintArray(int [] B) 
// {
//     for(int z = 0; z<B.Length; z++)
//     {
//         System.Console.Write(B[z] + " ");
//     }
// }

// GetArray (array);
// PrintArray (array);
// System.Console.WriteLine();
// System.Console.WriteLine(Count(array)+ " ");

// // 1 2 3 4 5 6
// // 6 5 4 3 2 1 

// string Count (int [] D)
// {
//     string result = string.Empty;
//     for(int i = 0; i < D.Length/2; i++)
//     {
//         result = result + $"{D[i]*D[D.Length -1 - i]} ";
//         //System.Console.WriteLine(result);
//     }
//     return result;
// }

// 40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

double[] array = new double[10];

double[] FillArray(double[] A)
{
    for (int i = 0; i < A.Length; i++)
    {
        A[i] = new Random().NextDouble() * 100;
    }
    return A;
}
array = FillArray(array);

void PrintArray(double[] A)
{
    for (int i = 0; i < A.Length; i++)
    {
        System.Console.WriteLine(A[i]);
    }
}
PrintArray(array);

System.Console.WriteLine();

double MinMax(double[] B)
{
    double Min = B[0];
    double Max = B[0];
    for (int i = 1; i < B.Length; i++)
    {
        if (Min > B[i]) // 5 = 2
        {
            Min = B[i];
        
        }
        if (Max < B[i]) // 1 = 2
        {
            Max = B[i];
        }
        
    }
System.Console.WriteLine(Min + " Минимальное");
System.Console.WriteLine(Max + " Максимальное");
double result = Max-Min;
return result;
}
// MinMax(array);
double res = MinMax(array);

System.Console.WriteLine(res + " Разница между максимальным и минимальным");

