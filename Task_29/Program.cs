﻿// Напишите программу, которая задаёт массив из некоторого количества элементов и выводит
// их на экран с помощью функций
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


int [] array_1 = new int [5]; //Задаём массивы и определяем количество символов в массиве
int [] array_2 = new int [3];

for (int i = 0; i < array_1.Length; i++)
{
    array_1 [i] = new Random().Next(1, 20); // Создаём рандомные числа в массиве от 1 до 19
    System.Console.Write($" {array_1[i]}, "); // выводим на печать через запятую все числа массива
}

System.Console.WriteLine(); // Разрыв строки

for (int i = 0; i < array_2.Length; i++)
{
    array_2 [i] = new Random().Next(1, 34); // Создаём рандомные числа в массиве от 1 до 34
    System.Console.Write($" {array_2[i]}, "); // выводим на печать через запятую все числа массива
}

System.Console.WriteLine(); // Разрыв строки
