// Recursion

Console.WriteLine("Task 63");
// Задайте значение N. Напишите прграмуу, 
// которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

int startNum = 1;

Console.Write("Type a number: ");
int num = int.Parse(Console.ReadLine());

string PrintNumbers(int start, int end)
{
    if (start == end)
    {
        return start.ToString();
    } 
    // When we use consentation of an intenger (start) and a string (" "), C# implicitly converts the integer to a string
    return (start + " " + PrintNumbers(start + 1, end));
}

Console.WriteLine(PrintNumbers(startNum, num));


Console.WriteLine("\nTask 64");
// Задайте занчения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

int m = 4;
int n = 10;

Console.WriteLine(PrintNumbers(m, n));
