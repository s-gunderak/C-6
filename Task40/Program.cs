// Задача 40: Напишите программу, которая принимает на вход три 
// числа и проверяет, может ли существовать треугольник с сторонами 
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника 
// меньше суммы двух других сторон.

int AskNumber(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine());
}

bool IsTriangleValid(int num1, int num2, int num3)
{
    return num2 + num3 > num1 && num1 + num3 > num2 && num1 + num2 > num3;
}

int num1 = AskNumber("Введите первое число: ");
int num2 = AskNumber("Введите второе число: ");
int num3 = AskNumber("Введите третье число: ");

if (IsTriangleValid(num1, num2, num3))
{
    Console.WriteLine("Треугольник может существовать");
}
else
{
    Console.WriteLine("Треугольник не может существовать");
}
