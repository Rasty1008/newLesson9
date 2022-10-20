/* Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

using static System.Console;

Clear();

WriteLine("Input number: ");
int number = int.Parse(ReadLine()!);
int numb = 1;

WriteLine(GetDigits(number, numb));


string GetDigits(int n, int m) {
    return (n==m)? n.ToString(): GetDigits(n, m+1) + "," +m;
}