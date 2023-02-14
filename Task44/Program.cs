// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

// int askNumber(string msg)
// {
//     Console.WriteLine(msg);
//     return int.Parse(Console.ReadLine());
// }

// int Fibonacci(int n)
// {
//     int prev = 0, curr = 1;
//     if (n == 1)
//     {
//         return prev;
//     }
//     if (n == 2)
//     {
//         return curr;
//     }
//     for (int i = 2; i < n; i++)
//     {
//         int temp = curr;
//         curr += prev;
//         prev = temp;
//         Console.Write(curr + " ");
//     }
//     return curr;
// }
// int num = askNumber("Введите число: ");
// int fib = Fibonacci(num);
// Console.WriteLine(fib);
// // мы не совсем верно решили, т.к. вывели только последнее число, а нужно было вывести всю последовательность

int AskNumber(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine());
}

int Fibonacci(int n)
{
    int prev = 0,
     curr = 1;

    if (n > 0)
    {
        Console.Write(prev + " ");
    }
    if (n <= 1)
    {
        return prev;
    }

    Console.Write(curr + " ");
    if (n == 2)
    {
        return curr;
    }

    for (int i = 2; i < n; i++)
    {
        int temp = curr;
        curr += prev;
        prev = temp;

        Console.Write(curr + " ");
    }
    Console.WriteLine();

    return curr;
}

int num = AskNumber("Введите число: ");
int fib = Fibonacci(num);
// Console.WriteLine(fib);
