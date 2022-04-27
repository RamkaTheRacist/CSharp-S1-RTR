//По заданному номеру дня недели вывести его название
Console.WriteLine("Which day of week?");
int digit = int.Parse(Console.ReadLine());
if(digit == 1)
{
    Console.WriteLine("Monday");
}
if(digit == 2)
{
    Console.WriteLine("Tuesday");
}
if(digit == 3)
{
    Console.WriteLine("Wednesday");
}
if(digit == 4)
{
    Console.WriteLine("Thursday");
}
if(digit == 5)
{
    Console.WriteLine("Friday");
}
if(digit == 6)
{
    Console.WriteLine("Saturday");
}
if(digit == 7)
{
    Console.WriteLine("Sunday");
}
else
{
    Console.WriteLine("Are u dumb?");
}
