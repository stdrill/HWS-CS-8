// Показать натуральные числа от M до N, N и M заданы

void PrintNumbers(int n, int m)
{
    if (n < m) return;
    Console.WriteLine($"{m}");
    PrintNumbers(n, m+1);
}

Console.WriteLine("Enter M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
PrintNumbers(numberN,numberM);