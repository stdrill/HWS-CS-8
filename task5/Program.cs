// Написать программу возведения числа А в целую стень B


int Exponentiation(int a, int b)
{
    if (b == 0) return 1;
    else return Exponentiation(a, b - 1) * a;
}

Console.Write("Enter number A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number B: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Exponentiation(a, b));
