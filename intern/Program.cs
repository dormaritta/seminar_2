//Написать программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа
//456 -> 6
//782 -> 2
//918 -> 8

Console.WriteLine("Введите трёхначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 100 && num < 1000) //&& - как и, условие выполняется при обоих и
{
    Console.WriteLine (num % 10);
}
else
{
    Console.WriteLine ("Ошибка");
}

//if (1 > 0 || 5 > 10) "||" - или, выполняется когда, одно из истинно
/* string some_string = Console.ReadLine;

int num = int.Parse(some_string); функция принимает строку и переводит в целочисленную переменную
int num = int.TryParse(some_string, out num); - ловля ошибок некорректных парсов*/