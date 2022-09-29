Console.WriteLine("Введите число");
int x = int.Parse(Console.ReadLine() ?? "0");
int sum = 0;
if (x < 0)
{
    x = Math.Abs(x);
}

while (x != 0)
{
    sum = sum + (x % 10);
    x = x / 10;
}

Console.WriteLine(sum);