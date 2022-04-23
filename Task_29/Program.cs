// Напишите программу, которая задаёт массив из некоторого количества элементов и выводит
// их на экран с помощью функций
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

//Console.WriteLine("Введите число соответствующее 6 чисел массива");
//int Array = Convert.ToInt32(Console.ReadLine()); // задаём строку для введения количества
// чисел в массиве

int [] array = new int[6]; // выделяем память на 6 элементов значения array

Console.WriteLine("Введите число первого элемента массива слева на право");
int array0 = Convert.ToInt32(Console.ReadLine()); // задаём строку для введения первого
// элемента массива
Console.WriteLine("Введите число второго элемента массива слева на право");
int array1 = Convert.ToInt32(Console.ReadLine()); // задаём строку для введения второго
// элемента массива
Console.WriteLine("Введите число третьего элемента массива слева на право");
int array2 = Convert.ToInt32(Console.ReadLine()); // задаём строку для введения третьего
// элемента массива
Console.WriteLine("Введите число четвертого элемента массива слева на право");
int array3 = Convert.ToInt32(Console.ReadLine()); // задаём строку для введения четвертого
// элемента массива
Console.WriteLine("Введите число пятого элемента массива слева на право");
int array4 = Convert.ToInt32(Console.ReadLine()); // задаём строку для введения пятого
// элемента массива
Console.WriteLine("Введите число шестого элемента массива слева на право");
int array5 = Convert.ToInt32(Console.ReadLine()); // задаём строку для введения шестого
// элемента массива


array[0] = array0; 
array[1] = array1;
array[2] = array2;
array[3] = array3;
array[4] = array4;
array[5] = array5;

//Console.WriteLine(array0, array1, array2, array3, array4, array5 ]);
Console.WriteLine($"[ {array[0]}, {array[1]}, {array[2]}, {array[3]}, {array[4]}, {array[5]} ]");