// Задача 19

//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

//14212 -> нет

//12821 -> да

//23432 -> да

Console.WriteLine("Введите пятизначное число");
string text = (Console.ReadLine());
int length = text.Length;

//  14212
//  01234
if (text[0] == text[4] && text[1] == text[3])
    {
        Console.WriteLine("является палиндромом");
    }
else 
    {
        Console.WriteLine("не является палиндромом");
    }
