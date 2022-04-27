//Найти третью цифру числа или сообщить, что её нет
Console.WriteLine("Number?");
int number = int.Parse(Console.ReadLine());
int digit = 0;
if(number < 99 && number > -99)
{
    Console.WriteLine($"{number} hasn`t third digit");
}
else
{
    int CurrentCounter = 0;
    int TotalCounter = 0;
    int tmpnumber = number;
    if(number > 0)
    {
     while(tmpnumber > 0)
     {
        tmpnumber = tmpnumber / 10;
        TotalCounter++;
        //Console.WriteLine($"counter = {TotalCounter}");
     }
    }
    else
    {
       while(tmpnumber < 0)
     {
        tmpnumber = tmpnumber / 10;
        TotalCounter++;
        //Console.WriteLine($"counter = {TotalCounter}");
     }   
    }
    int counter = Math.Abs(-TotalCounter + 2);
    while(CurrentCounter < counter)
    {
        digit =  number % 10;
        number = number / 10;
        CurrentCounter = CurrentCounter + 1;
    }
    Console.WriteLine($"{digit} is third digit");
}
