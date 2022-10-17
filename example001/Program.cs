// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.WriteLine("ВВедите трехзначное число");
string numberStr = Console.ReadLine() ??"";
int number = int.Parse(numberStr);
if (number >= 100 && number <= 999 || number <= -100 && number >= -999)
{
    int result = Math.Abs((number / 10) % 10);
    Console.WriteLine($"Число {result}");
}
else
{
    Console.WriteLine("Число НЕ трехзначное");
}
