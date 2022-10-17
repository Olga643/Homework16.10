// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine ("Ведите число от 1 до 7");
string numberStr = Console.ReadLine() ??"";
int number = int.Parse(numberStr);

if ( number > 5 && number <= 7)
{ 
    Console.WriteLine ("Ура! Выходной");
}   
else if(number >= 1 && number <= 5)
{
    Console.WriteLine ("Будний день");
} 
else 
{
    Console.WriteLine ("В неделе СЕМЬ дней, введите число от 1 до 7");
}
