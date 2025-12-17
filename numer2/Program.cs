Random random = new Random();
int l1 = random.Next(1, 100);
int l2 = 0;
int próby = 0;
Console.WriteLine("Podaj liczbe od 1 do 100");
próby++;
while (l2 != l1)
{
    l2 = Convert.ToInt32(Console.ReadLine());
    if (l2 > 100)
    {
        próby++;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("troche za dużo");
        Console.ForegroundColor = ConsoleColor.White;
    }
    else if (l2 <= 0)
    {
        próby++;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("troche za mało");
        Console.ForegroundColor = ConsoleColor.White;
    }
    else if(l2 < l1)
    {
        próby++;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Więcej");
        Console.ForegroundColor = ConsoleColor.White;
    }
    else if (l2 > l1)
    {
        próby++;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Mniej");
        Console.ForegroundColor = ConsoleColor.White;
    }
}
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("zgadłeś " + l2 + " jest poprawna");
Console.WriteLine("zgadłeś w " + próby + " próbach");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("wykonane przez Antoni T-P");