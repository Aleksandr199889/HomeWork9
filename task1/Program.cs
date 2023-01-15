// Задача 1: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите натуральное число N");
int N = Convert.ToInt32(Console.ReadLine());
int m = N;
for(int i = 0; i < N; i = i + 1)
{
    if (N < 0) 
    {
        Console.Write("не натуральное число");
    }
    else
    if (m == 0) return;
    Console.Write(m + " ");
    m = m - 1;
}

// void array(int n)
// {
//     if (n == 0) return;
//     Console.Write("{0,4}", n);
//     array (n - 1);
// }

// array(N);


// int Factorial(int n)
// {
//     if (n == 1) return 1;
 
//     return n * Factorial(n - 1);
// }
// NumberCounter()
// int factorial4 = Factorial(4);  // 24
// int factorial5 = Factorial(5);  // 120
// int factorial6 = Factorial(6);  // 720
 
// Console.WriteLine($"Факториал числа 4 = {factorial4}");
// Console.WriteLine($"Факториал числа 5 = {factorial5}");
// Console.WriteLine($"Факториал числа 6 = {factorial6}");
// Factorial(N);


// Console.WriteLine("Введите натуральное число больше 1:");
// int number = int.Parse(Console.ReadLine());

// ///Метод вывода натуральных чисел от N до 1:
// void NumberCounter (int number)
// {
//     if (number < 0) Console.Write($"{number} не натуральное число");
//     if (number == 0) return;
//     Console.Write("{0,4}", number);
//     NumberCounter (number - 1);
// }

// NumberCounter(number);