//Показать числа от -N до N
double n = double.Parse(Console.ReadLine());
double nmax = n;
double nmin = -n;
while(nmin <= nmax)
{
    Console.WriteLine(nmin);
    nmin = nmin + 1;
}