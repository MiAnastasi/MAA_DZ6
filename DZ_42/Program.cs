// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

int number = Convert.ToInt32(Console.ReadLine());
string binary = Convert.ToString(number, 2);
Console.WriteLine(binary);