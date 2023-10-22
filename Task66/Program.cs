﻿int SumNumbers(int M, int N)
{
    if (M > N)
    {
        return N + SumNumbers(M, N + 1);;
    }

    else if(M == N) return 0;

    else return M + SumNumbers(M + 1, N);
}

Console.Write("Введите значение M: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение N: ");
int N = Convert.ToInt32(Console.ReadLine());

int sum = SumNumbers(M, N);
Console.WriteLine($"Сумма натуральных чисел от {M} до {N}: {sum}");