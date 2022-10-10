//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int SummOfDigits(int number)
{
    int result = 0;
    while (number !=0)
    {
        result += number % 10;
        number = number / 10;
    }
    return result;
}

Console.WriteLine("Введите целожтельное число: ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int result = SummOfDigits(number);
Console.WriteLine($"Сумма всех цифр числа {number} составляет: {result}");
