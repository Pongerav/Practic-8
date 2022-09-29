int Akkerman(int m, int n)
{
    if (m == 0) return n+1;
    else if ((m!=0) && (n == 0)) return Akkerman(m-1,1);
    else if ((m > 0) && (n> 0)) return Akkerman(m-1,Akkerman(m,n-1));
    else return 1;
}

Console.WriteLine("Введите число M");
int m = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Введите число N");
int n = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine(Akkerman(m,n));