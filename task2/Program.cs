// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.WriteLine("Введите натуральное число N");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число M");
int M = Convert.ToInt32(Console.ReadLine());
int S = 0;
static int SumOfDigit(int n, int m, int S)
{
    if (n <= m)
    {
        S = S + n;
        n++;
        int result = SumOfDigit(n,m,S);
        return S;
    }
    else
    {
        Console.Write(S);
        return S;
    }
}

SumOfDigit(N,M,S);
