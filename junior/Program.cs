/* Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа
78->8
12->2
85->8 */

int start = 10;
int end = 100;

int num = new Random().Next(start, end);
Console.WriteLine("Случайно число: " + num);

int num_1 = num % 10;
int num_2 = num / 10;

int max_num = num_1;
if (num_2 > max_num) max_num = num_2;

Console.WriteLine("Большее число: " + max_num);
//или Console.WriteLine($"Большее число: + {max_num}"); {любые значения, даже например ридлайн(считать строку)}