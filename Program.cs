//Домашнее задание
//Задача 64: **Выполнить с помощью рекурсии**.
//Задайте значение N. Напишите программу, 
//которая выведет все натуральные числа в промежутке 
//от N до 1. 
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

/*Console.WriteLine($"Введите число N: ");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine(PrintNumbers(N, 1));

string PrintNumbers(int start, int end){
    if (end == start) return end.ToString();
    return (start + " " + PrintNumbers(start - 1, end));
}*/

//Задача 66: **Выполнить с помощью рекурсии**.
//Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в 
//промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

/*Console.WriteLine($"Введите число M: ");
int M = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Введите число N: ");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine(SummNumbers(M, N));

int SummNumbers( int start, int end){
    int summ = start;
    if (start == end) return start;
    return(summ + SummNumbers(start + 1, end));
}*/

/*Задача 68: **Выполнить с помощью рекурсии**.
Напишите программу вычисления функции Аккермана 
с помощью рекурсии. Даны два неотрицательных 
числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/

Console.WriteLine($"Введите число M: ");
int M = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Введите число N: ");
int N = int.Parse(Console.ReadLine()!);

int functionAkkerman = Ack(M, N);
Console.Write($"Функция Аккермана = {functionAkkerman} ");

int Ack(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return Ack(m - 1, 1);
  else return Ack(m - 1, Ack(m, n - 1));
}

