// Написать программу вычисления функции Аккермана


int AckFunction(int a, int b)
{
  if (a == 0)
    return b + 1;
  else
    if ((a != 0) && (b == 0))
      return AckFunction(a - 1, 1);
    else
      return AckFunction(a - 1, AckFunction(a, b - 1));
}

Console.WriteLine("Enter A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter B: ");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(AckFunction(A,B));