// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.


void NumberSummary (int number1, int number2, int sum)
{
    if (number1 > number2) 
    {
        Console.WriteLine($"Сумма натуральных чисел в промежутке от M до N: {sum}"); 
        return;
    }
    sum = sum + (number1++);
    NumberSummary(number1, number2, sum);
}

Console.Write("Введите первое число: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int N = Convert.ToInt32(Console.ReadLine());

NumberSummary(M, N, 0);

