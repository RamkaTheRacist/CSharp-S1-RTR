//Выяснить, кратно ли число заданному, если нет, вывести остаток
Console.WriteLine("Number?");
int number = int.Parse(Console.ReadLine());
Console.WriteLine("On what will divibe by?");
int number1 = int.Parse(Console.ReadLine());
if(number % number1 == 0)
{
    Console.WriteLine($"{number} is multiple of {number1}");
}
else
{
    int tmp = number % number1;
    Console.WriteLine($"{tmp} is remainder of {number} divibed by {number1}");
}
