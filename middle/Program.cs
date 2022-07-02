/* Напишите программу, которая будет принимать на вход два числа и выводить, является ли первое число кратным второму.
Если число 1 не крастно числу 2, то программа выводит остаток от деления.
34, 5 -> не кратно, остаток 4
16, 4 -> кратно  */

Console.WriteLine("Введите первое число: ");
int num_1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num_2 = Convert.ToInt32(Console.ReadLine());

if (num_1 % num_2 == 0)
{
    Console.WriteLine("Кратно");
}
else
{
    int modulo = num_1 % num_2;
    Console.WriteLine("Не крастно, остаток от деления: " + modulo);
}