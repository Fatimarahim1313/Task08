// Задайте две матрицы. Напишите программу, которая будет 
// находить произведение двух матриц.

int[,] A = new int[3, 3];
int[,] B = new int[3, 4];
if (A.GetLength(1) != B.GetLength(0))
{
    Console.WriteLine("Данные матрицы приумножить невозможно");
}

Random rnd = new Random();
Console.WriteLine("Матрица А:");
for (int i = 0; i < A.GetLength(0); i++)
{
    for (int j = 0; j < A.GetLength(1); j++)
    {
        A[i, j] = rnd.Next(0, 11);
        Console.Write($"{A[i, j]}\t");
    }
    Console.WriteLine();
}
Console.WriteLine("Матрица B:");
for (int i = 0; i < B.GetLength(0); i++)
{
    for (int j = 0; j < B.GetLength(1); j++)
    {
        B[i, j] = rnd.Next(0, 11);
        Console.Write($"{B[i, j]}\t");
    }
    Console.WriteLine();
}

Console.WriteLine("Матрица C (результат произведение А х B):");
int[,] C = new int[A.GetLength(0), B.GetLength(1)];

for (int i = 0; i < C.GetLength(0); i++)
{
    for (int j = 0; j < C.GetLength(1); j++)
    {
        C[i, j] = GetMultipleResult(A, B, i, j);
        Console.Write($"{C[i, j]}\t");
    }
    Console.WriteLine();
}

int GetMultipleResult(int[,] A, int[,] B, int ci, int cj)
{
    int result = 0;
    for (int i = 0; i < A.GetLength(0); i++)
    {
        result += A[ci, i] * B[i, cj];
    }
    return result;
}


