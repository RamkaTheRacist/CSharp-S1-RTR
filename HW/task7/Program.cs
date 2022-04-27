//Удалить вторую цифру трёхзначного числа
Console.WriteLine("Number?");
int number = int.Parse(Console.ReadLine());
int d3 = number % 10;
int d2 = (number % 100) / 10; 
int d1 = number / 100;
int current = d1 * 10 + d3;
Console.WriteLine($"Answer is {current}");
