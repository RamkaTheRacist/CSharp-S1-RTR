//По двум заданным числам проверять является ли первое квадратом второго
int n1 = int.Parse(Console.ReadLine());
int n2 = int.Parse(Console.ReadLine());
if((n2 * n2) == n1)
{
    Console.WriteLine($"Yes, {n1} is square of {n2}");
}
else
{
    Console.WriteLine($"No, {n1} isn`t square of {n2}");
}