// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите два числа:  ");
int A =
int.Parse(Console.ReadLine()!);
int D =
int.Parse(Console.ReadLine()!);
int result = A;
for (int i = 1; i < D; i++)
{
    result = result * A;
}
Console.WriteLine(result);