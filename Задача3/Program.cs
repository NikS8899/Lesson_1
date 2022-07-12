Console.WriteLine("Проверка четности числа, введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n %2 == 0)
{
Console.WriteLine("Число является четным!");
}
else
{
    Console.WriteLine("Число НЕ является четным!");
}