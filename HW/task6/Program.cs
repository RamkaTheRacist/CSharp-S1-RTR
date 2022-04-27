//Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
Console.WriteLine("Number?");
int number = int.Parse(Console.ReadLine());
int digit1 = number / 10;
int digit2 = number % 10;
if(number >= 10 && number <= 99)
{
    if(digit1 > digit2)
    {
        Console.WriteLine($"Max digit = {digit1}, Min digit = {digit2}");
    }
    else
    {
        Console.WriteLine($"Max digit = {digit2}, Min digit = {digit1}");
    }
}
else
{
    Console.WriteLine("Wrong input data");
}