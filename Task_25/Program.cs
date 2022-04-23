// Напишите (функцию) цикл, который принимает на входдва числа (А и В) и возводит 
// число А в натуральную степень В.
// 3, 5 -> 243 (3^5)
// 2, 4 -> 16 (2^4)

Console.WriteLine("Введите первое число, являющейся основанием степени");
int A = Convert.ToInt32(Console.ReadLine()); // задаём строку для введения 1 числа
Console.WriteLine("Введите второе число, являющейся показателем степени");
int B = Convert.ToInt32(Console.ReadLine()); // задаём строку для введения 2 числа

int i = Convert.ToInt32(Math.Pow(A, B));

System.Console.WriteLine(i);
