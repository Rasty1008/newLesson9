/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

using static System.Console;

Clear();

WriteLine("Input N number: ");
int firstNumber = int.Parse(ReadLine()!);
WriteLine("Input M number: ");
int secondNumber = int.Parse(ReadLine()!);

WriteLine(GetNumbers(firstNumber, secondNumber));

int GetNumbers(int n, int m) {
    if(n == m) return m;
    return m + GetNumbers(n, m-1);  
}

