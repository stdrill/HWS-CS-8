// Найти сумму цифр числа

int DigitSum(int n)
{
    if (n == 0) return 0;
    return n % 10 + DigitSum(n / 10);
}

Console.WriteLine("Enter number: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Sum of digits {DigitSum(n)}");
