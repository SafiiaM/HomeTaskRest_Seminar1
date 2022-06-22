// Задача 7: Напишите программу, которая принимает на вход трёхзначное число и на
// выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8


Console.Write("Введите трехзначное число: ");
int abc = Convert.ToInt32(Console.ReadLine());
int c = abc % 10;
if (abc < 100 && abc > 999)
{
    Console.WriteLine("Некорректные данные");
}
else
{
    Console.Write(c);
}

Console.ReadKey();

