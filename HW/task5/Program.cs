//Показать вторую цифру трёхзначного числа
Console.WriteLine("Number?");
int number = int.Parse(Console.ReadLine());
int tmp = number / 10;
int SecondDigit = tmp % 10;
Console.WriteLine($"Second digit of {number} is {SecondDigit}");
