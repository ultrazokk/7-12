// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] array2D = {
    {1, 2, 3},
    {4, 5, 6},
    {7, 8, 9}
};

Console.WriteLine("Введите индексы элемента в массиве: ");

Console.Write("Индекс строки: ");
int row = int.Parse(Console.ReadLine());

Console.Write("Индекс столбца: ");
int col = int.Parse(Console.ReadLine());

int numRows = array2D.GetLength(0);
int numCols = array2D.GetLength(1);

if (row >= 0 && row < numRows && col >= 0 && col < numCols)
{
    int value = array2D[row, col];
    Console.WriteLine($"Значение элемента: {value}");
}
else
{
    Console.WriteLine("Элемент с указанными индексами отсутствует в массиве.");
}
