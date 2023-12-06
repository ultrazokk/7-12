// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
int[,] array = {
            { 1, 21, 3 },
            { 4, 9, 6 },
            { 7, 2, 9 }
        };

int smallestRowIndex = -1;
int smallestSum = int.MaxValue;

for (int i = 0; i < array.GetLength(0); i++)
{
    int currentSum = 0;

    for (int j = 0; j < array.GetLength(1); j++)
    {
        currentSum += array[i, j];
    }

    if (currentSum < smallestSum)
    {
        smallestSum = currentSum;
        smallestRowIndex = i;
    }
}

Console.WriteLine($"Строка с наименьшей суммой элементов: {smallestRowIndex}");







