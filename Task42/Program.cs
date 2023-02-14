// Задача 42: Напишите программу, которая будет преобразовывать 
// десятичное число в двоичное.
// Суть метода перевода десятичного в двоичное
// 45 -> 101101
// 3 -> 11
// 2 -> 10

int askNumber(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine());
}

int num = askNumber("Введите десятичное число: ");

string Binary(int num)//этот метод переводит десятичное число в двоичное. т.к. нам нужно будет выводить в строку числа
// по результату взятия остатка от деления на 2 (т.е. не брать их сумму), мы делаем тип данных string
{
    int notation = 2;//ввели переменную notation, которая позволяет изменить только её саму и переводить числа не только в двоичную, 
    //но и 16ю и другие системы, т.е. мы меняем только знаечение переменной notation и в цикле все её значения менять не нужно
    string sum = String.Empty;// тоже тип string, т.к. sum нужно не суммировать, а выводить строкой подряд все числа от взятия остатка
    while (num > 0)
    {
        sum = num % notation + sum;//ВАЖНО!!! sum прибавляем вконце, т.к. благодаря этому формула сразу будет
        //переворачивать полученную последовательность
        num /= notation;//по формуле перевода десятичного в двоичную
    }
    return sum;
}
Console.WriteLine(Binary(num));

// Метод от преподавателя:
// string res1
// //Универсальный математический для перевода из 10 в любую
// string DecToNum(int decNumber, int otherSystem)
// {
//     string res="";
//     string nums="0123456789ABCDEF";
//     while(decNumber>0)
//     {
//         int ost=decNumber/otherSystem;
//         res=nums[decNumber-otherSystem*ost]+res;
//         decNumber/=otherSystem;
//     }
//     return res;
// }
