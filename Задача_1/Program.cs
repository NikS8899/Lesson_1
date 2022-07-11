Console.WriteLine("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());
int max = 0;
int min = 0;
if (a<b)
{
    max = b;
    Console.WriteLine("Максимальное число = " + max);
    min = a;
    Console.WriteLine("Минимальное число = " + min);
}
else
{
    max = a;
    Console.WriteLine("Максимальное число = " + max);
    min = b;
    Console.WriteLine("Минимальное число = " + min);
}
if (a == b)
{
    Console.WriteLine("Числа равны!");
}