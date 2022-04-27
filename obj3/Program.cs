//Найти максимальное из трех чисел
int n1 = int.Parse(Console.ReadLine());
int n2 = int.Parse(Console.ReadLine());
int n3 = int.Parse(Console.ReadLine());
int max = n1;
if(n2 > n1)
{
    max = n2;
}
if(max < n3)
{
    max = n3;
}
Console.Write("max = ");
Console.Write(max);