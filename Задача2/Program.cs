int max = 0;
Console.WriteLine("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a>max)
{
    max = a;
}

Console.WriteLine("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());
if (b>max)
{
    max = b;
}
Console.WriteLine("Введите число c: ");
int c = Convert.ToInt32(Console.ReadLine());
if (c>max)
{
    max = c;
}
Console.WriteLine("Максимальное число: " + max);