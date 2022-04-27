//Показать четные числа от 1 до N
Console.WriteLine("Number?");
int number = int.Parse(Console.ReadLine());
int tmp = 1;
if(number == 1)
{
    Console.Write("Nothing here");
}
else
{
 if(number > 1) 
 {
    while(number >= tmp)
    {
        if(tmp % 2 == 0)
        {
        Console.Write(" "+tmp);
        }
    tmp++ ;
    }
 }
 else
 {
    while(tmp >= number)
    {
        if(tmp % 2 == 0)
        {
        Console.Write(" "+tmp);
        }
    tmp-- ;
    }
 }
}