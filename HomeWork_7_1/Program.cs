Console.Clear();
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными
// числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
void FindMatrix(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = Math.Round(new Random().NextDouble(), 2) + new Random().Next(0, 10);
        }
    }
}
void PrintMatrix(double[,] matr){
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]}  \t");
        }
        Console.WriteLine();
    }
}
int Rows = Prompt("Длина строки: m = ");
int Columns = Prompt("Длина столбцы: n = ");

double[,] matrix = new double[Rows, Columns];
FindMatrix(matrix);

PrintMatrix(matrix);