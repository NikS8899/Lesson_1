Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
int number = 1;
Console.WriteLine("Все четные числа от 1 до N: ");
while (number < n)
{
number ++;
if (number %2 == 0)
{
    Console.WriteLine(number);
}

}

