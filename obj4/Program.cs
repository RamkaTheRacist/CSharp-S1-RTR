//Показать числа от -N до N
double n = double.Parse(Console.ReadLine());
double nmax = n;
double nmin = -n;
while(nmin <= nmax)
{
    Console.Write(" " + nmin); // " " - отступ
    nmin = nmin + 1; // or nmin ++ 
}