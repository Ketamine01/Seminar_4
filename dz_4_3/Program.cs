//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

void PrintArr(string [] array)
{
    int length = array.Length;
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }
}
string [] arr = new string [8]; // число 8 длинна массива)
for (int i = 0; i < 8; i++)
{
    Console.WriteLine($"введите {i + 1}-й элемент массива");
    arr[i] = Console.ReadLine();
}

    Console.WriteLine();

PrintArr(arr);
    