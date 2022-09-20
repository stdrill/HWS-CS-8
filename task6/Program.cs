// Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих.

void Fibonacci(int a, int b, int n)
{
    if (n == 0) return;
    else {
        Console.Write((a + b) + " ");
        Fibonacci(b, a + b, n - 1);
    }
}

Console.WriteLine("Enter number A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number B: ");
int B = Convert.ToInt32(Console.ReadLine());
int N = 10;
Fibonacci(A, B, N);