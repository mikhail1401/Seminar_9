// Recursion

Console.WriteLine("Task 63");
// Задайте значение N. Напишите прграмуу, 
// которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

int startNum = 1;

Console.Write("Type a number: ");
int num = int.Parse(Console.ReadLine());

string PrintNumbers1(int start, int end)
{
    if (start == end)
    {
        return start.ToString();
    } 
    // When we use consentation of an intenger (start) and a string (" "), C# implicitly converts the integer to a string
    return (start + " " + PrintNumbers1(start + 1, end));
}

Console.WriteLine(PrintNumbers1(startNum, num));


Console.WriteLine("\nTask 64");
// Задайте занчения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

int m = 4;
int n = 10;

string PrintNumbers2(int num1, int num2)
{
    if (num1 > num2)
    {
        return PrintNumbers1(num2, num1);
    } 
    else if (num1 <= num2)
    {
        return PrintNumbers1(num1, num2);
    }
    else return " ";
}

Console.WriteLine(PrintNumbers2(m, n));


Console.WriteLine("\nTask 67");
// Задача 67: Напишите программу, которая будет 
// принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.Write("Type a number: ");
int x = int.Parse(Console.ReadLine());

int SumOfDigits(int num)
{
    if (num%10 == 0 && num/10 == 0) return 0;
    else
    {
        return num%10 + SumOfDigits(num/10);
    }
}

Console.WriteLine(SumOfDigits(x));
