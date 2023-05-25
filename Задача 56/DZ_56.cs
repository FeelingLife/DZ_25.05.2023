//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.WriteLine("");
int rows = InputNumbers("Введите количество строчек: ");
int columns = InputNumbers("Введите количество столбцов: ");
int range = InputNumbers("Введите диапазон значений: от 1 до ");
int[,] array = new int[rows, columns];

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

void CreateArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(range);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void RowSmallestSumOfNumbers(int[,] array)
{
    int counter = 1;
    int result = 0;
    for (int i = 0; i < array.GetLength(0); i++, counter++)
    {
        for (int j = 0; j < array.GetLength(1); j++)    // Суммируем значение строк
        {
            result = result + array[i, j];
        }
        Console.Write($"Сумма чисел в {counter} строке - ({result})");
        result = 0;
        Console.WriteLine("");
    }
    
}

CreateArray(array);
Console.WriteLine("");
Console.WriteLine("Массив: ");
Console.WriteLine("");
PrintArray(array);
Console.WriteLine("");
Console.WriteLine("Рачет построчно: ");
RowSmallestSumOfNumbers(array);
Console.WriteLine("");
Console.WriteLine($"Минимальная сумма в строке - ");

