int Power(int a,int b)
{
    if (b == 0) return 1;
    return a * Power(a,b-1);
}

Console.WriteLine("Введите основание a");
int a = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Введите показатель степени b");
int b = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine(Power(a,b));