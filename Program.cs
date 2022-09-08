//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30
/*
int SumNature(int m, int n)
{
    if (m < n) return SumNature(m + 1, n) + m;
        else return m;   
}

Console.WriteLine("Please input start number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please input finish number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine("Your start number is bigger than finish number. We have to swap them =)");
    int temp = num1;
    num1 = num2;
    num2 = temp;
}

Console.Write($"Sum of natural numbers between {num1} and {num2} is {SumNature(num1, num2)}");
*/

//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 29
/*
int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else
        {
        if ((m != 0) && (n == 0)) return Akkerman(m - 1, 1);
            else return Akkerman(m - 1, Akkerman(m, n - 1));
        }
}

Console.WriteLine("Please input start number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please input finish number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write($"The result of Akkerman's function is {Akkerman(num1, num2)}");
*/