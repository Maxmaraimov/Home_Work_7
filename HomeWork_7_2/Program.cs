Console.Clear();
// Задача 50. Напишите программу, которая на вход принимает позиции элемента в 
// двумерном массиве, и возвращает значение этого элемента или же указание, что такого 
// элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
void FindMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 50);
        }
    }
}
void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]}  \t");
        }
        Console.WriteLine();
    }
}
string ReleaseMatrix(int[,] matr)
{
    Console.Write("Введите позицию элемента в массиве: ");

    int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (i == size[0] && j == size[1])
            {
                return $"Значение элемента в массиве:  {matr[i, j]}";
            }
        }
    }
    return "Значение элемента в массиве нет";
}
int Rows = Prompt("Длина строки: m = ");
int Columns = Prompt("Длина столбцы: n = ");

int[,] matrix = new int[Rows, Columns];
FindMatrix(matrix);

PrintMatrix(matrix);
Console.WriteLine(ReleaseMatrix(matrix));
