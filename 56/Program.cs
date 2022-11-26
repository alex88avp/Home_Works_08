// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
Console.Clear();

Console.Write("Введите количсевто строк: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количсевто столбцов: ");
int columns = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Строка № {SumNumbersRows(array)} является с наименьшей суммой элементов");


int[,] GetArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

int SumNumbersRows(int[,] arr2)
{
    int minSum = 0;
    int row = 0;
    for (int i = 0; i < arr2.GetLength(1); i++)
    {
        minSum += arr2[0, i];
    }
    for (int i = 1; i < arr2.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
            sum += arr2[i, j];
        }
        if (minSum > sum)
        {
            minSum = sum;
            row = i;
        }
    }
    return row;
}
    