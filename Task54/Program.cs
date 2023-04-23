// Задайте двумерный массив. Напишите программу, которая 
// упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] arr = new int[5, 5];
Random rnd = new Random();

Console.WriteLine("Исходный массив:");
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = rnd.Next(100, 999);
        Console.Write($"{arr[i,j]}\t");
    }
    Console.WriteLine();
}

Console.WriteLine("Сортированный массив:");
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        for (int k = j + 1; k < arr.GetLength(1); k++)
        {
            if (arr[i, k] > arr[i, j])
            {
                int temp = arr[i, k];
                arr[i, k] = arr[i, j];
                arr[i, j] = temp;
            }
        }
        Console.Write($"{arr[i,j]}\t");
    }

     Console.WriteLine();
}




