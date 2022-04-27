// Даны два числа. Показать большее и меньшее число
int n1 = int.Parse(Console.ReadLine());
int n2 = int.Parse(Console.ReadLine());
if(n1 > n2)
{
    Console.Write("Max = ");
    Console.WriteLine(n1);
    Console.Write("Min = ");
    Console.Write(n2);
}
else
{
    Console.Write("Max = ");
    Console.WriteLine(n2);
    Console.Write("Min = ");
    Console.Write(n1);
}
