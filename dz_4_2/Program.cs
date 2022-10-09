//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
try
{
    Console.WriteLine("Введите целое число");
    int a = Math.Abs(int.Parse(Console.ReadLine()));
    int sum = 0;
    while (a > 99)
    {
        sum = sum + a % 10;
        a = a / 10;
    }
    sum = sum + a % 10 + a / 10;
    Console.WriteLine($"сумма цифр введенного числа равна {sum}");
}
catch
{
    Console.WriteLine();
}