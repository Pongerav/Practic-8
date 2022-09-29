int Fibonachi(int a1, int a2,int n)
{
    if (n == 2) return a2;
    if ((n != 1) && (n != 2))  return Fibonachi(a1,a2,n-1) + Fibonachi(a1,a2,n-2);
    if (n == 1)  return a1;
    else return 0;
}

Console.WriteLine("Введите первый член последовательности");
int a1 = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Введите второй член последовательности");
int a2 = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Введите количество необходимых членов");
int n = int.Parse(Console.ReadLine() ?? "0");

for (int i = 1; i <= n; i++)
{
    Console.Write(Fibonachi(a1,a2,i) + " ");
}