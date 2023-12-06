// Задайте двумерный массив из целых чисел. Напишите программу, 
// которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива. 
// Под удалением понимается создание нового двумерного массива без строки и столбца

int[,] array = {
            { 5, 7, 2 },
            { 3, 8, 1 },
            { 4, 6, 9 }
        };

int minRow = 0, minCol = 0;
int minElement = array[0, 0];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (array[i, j] < minElement)
        {
            minElement = array[i, j];
            minRow = i;
            minCol = j;
        }
    }
}

int[,] newArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
int newRow = 0, newCol = 0;

for (int i = 0; i < array.GetLength(0); i++)
{
    if (i == minRow)
        continue;

    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (j == minCol)
            continue;

        newArray[newRow, newCol] = array[i, j];
        newCol++;
    }

    newCol = 0;
    newRow++;
}

Console.WriteLine("Новый массив без строки и столбца с наименьшим элементом:");
for (int i = 0; i < newArray.GetLength(0); i++)
{
    for (int j = 0; j < newArray.GetLength(1); j++)
    {
        Console.Write(newArray[i, j] + " ");
    }
    Console.WriteLine();
}


