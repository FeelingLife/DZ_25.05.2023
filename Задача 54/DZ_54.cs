// // Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
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

void OrderArrayNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}
Console.WriteLine("");
Console.WriteLine($"Изначальный массив: ");
Console.WriteLine("");
CreateArray(array);
PrintArray(array);
Console.WriteLine("");
Console.WriteLine($"Отсортированный массив: ");
Console.WriteLine("");
OrderArrayNumbers(array);
PrintArray(array);
Console.WriteLine("");