// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// Выполнить с помощью рекурсии.

int SumNumbers(int M, int N)
{
    if (M > N)
    {
        return N + SumNumbers(M, N + 1);
    }

    else if(M == N) return M;

    else return M + SumNumbers(M + 1, N);
}

Console.Write("Введите значение M: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение N: ");
int N = Convert.ToInt32(Console.ReadLine());

int sum = SumNumbers(M, N);
Console.WriteLine($"Сумма натуральных чисел от {M} до {N}: {sum}");