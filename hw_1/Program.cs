// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

void NumberPrint (int val)
{
    if (val < 0) 
        Console.WriteLine("Введите натуральное число!");
    if (val == 0) 
        return;
        Console.Write("{0,4}", val);
    
    NumberPrint (val - 1);
}

NumberPrint(N);