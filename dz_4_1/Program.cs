/*
Напишите цикл, который принемает на входи два числа (А и В)
и возводит число А в натуральную степень В.
*/
int NumberInDegree(int number, int degree)
{
    int result = number;
    {
        for (int i = 1; i < degree; i++)
        {
            result = result * number;
        }
    }
    return result;
}

Console.Write("Введите целое натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральную степень числа: ");
int degree = Convert.ToInt32(Console.ReadLine());

if (degree > 0)
{
    int itog = NumberInDegree(number, degree);
    Console.WriteLine("-------------------");
    Console.WriteLine($"Число {number} в степени {degree} = {itog}");
}
else
{
    Console.WriteLine("---------------");
    Console.WriteLine("Вы ввели неверное данные!");
    Console.WriteLine($"Степень = {degree}");
}
    
// Воспользуемся встроенной функцией возведения в степень!
Console.WriteLine("");
Console.WriteLine($"Число {number} в степени {degree} = {Math.Pow(number, degree)}");

