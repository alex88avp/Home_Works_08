// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
Console.Clear();

Console.Write("Введите количество строк первого массива: ");
int rowsA = int.Parse(Console.ReadLine());
Console.Write("Введите количесвто столбцов первого массива: ");
int columnsA = int.Parse(Console.ReadLine());
Console.Write("Введите количество строк второго массива: ");
int rowsB = int.Parse(Console.ReadLine());
Console.Write("Введите количесвто столбцов второго массива: ");
int columnsB = int.Parse(Console.ReadLine());

if (columnsA != rowsB)
{
    Console.WriteLine("Ошибка!!!");
    return;
}

int[,] arrayA = GetArray(rowsA, columnsA, 0, 10);
int[,] arrayB = GetArray(rowsB, columnsB, 0, 10);
PrintArray(arrayA);
Console.WriteLine();
PrintArray(arrayB);
Console.WriteLine();
PrintArray(MultMatrix(arrayA, arrayB));

int[,] GetArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
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

int[,] MultMatrix(int[,] arr, int[,] arr2)
{
    int[,] arr3 = new int[arr.GetLength(0), arr2.GetLength(1)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(1); k++)
            {
                arr3[i, j] += arr[i, k] * arr2[k, j];
            }
        }
    }
    return arr3;
}
