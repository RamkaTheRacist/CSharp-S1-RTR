//Выяснить является ли число чётным. С оговоркой для положительных чисел
Console.WriteLine("Which number?");
int number = int.Parse(Console.ReadLine());
if(number % 2 == 0)
{
    Console.Write("Even number");
}
else
{
    Console.Write("Odd number");
}
