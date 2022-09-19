// Найти сумму элементов от M до N, N и M заданы

int SumNumbers(int m, int n)
{
     if (n == m) return n;
    return (m + SumNumbers(m + 1, n));
}

Console.WriteLine("Enter M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{SumNumbers(numberM,numberN)}");
