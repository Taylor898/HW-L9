int ack(int n, int m)
{
    if (n == 0) return m + 1;
    else if (m == 0) return ack(n - 1, 1);
    else return ack(n - 1, ack(n, m - 1));
}

Console.WriteLine("Enter m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter n");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"F({m},{n}) = {ack(m, n)}");