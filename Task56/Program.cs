// Задайте прямоугольный двумерный массив. Напишите 
// программу, которая будет находить строку с наименьшей суммой элементов.
int[,] arr = new int[7, 5];
Random rnd = new Random();
double minRowSumm = 0;
int rowIndex = 0;


Console.WriteLine("Исходный массив:");
for (int i = 0; i < arr.GetLength(0); i++)
{
    double rowSumm = 0;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = rnd.Next(10, 99);
        Console.Write($"{arr[i, j]}\t");
        rowSumm += arr[i, j];
    }

    if (i == 0)
    {
        minRowSumm = rowSumm;
    }
    else if (minRowSumm > rowSumm)
    {
        minRowSumm = rowSumm;
        rowIndex = i;
    }
    Console.WriteLine();
}

Console.WriteLine($"Индекс строки с минимальной суммой элементов: {rowIndex} Cумма строки: {minRowSumm}");
for (int j = 0; j < arr.GetLength(1); j++)
{
    Console.Write($"{arr[rowIndex, j]}\t");
}
Console.WriteLine();



