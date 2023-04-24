string f(int n)
{
    if (n == 1)
        return "1 ";
    return $"{n} " + f(n - 1);
}
System.Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
System.Console.WriteLine(f(n));