//задайте двумерный массив. Напишите программу, 
//которая поменяет местами первую и последнюю строку массива.
int[,] myArray = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

Console.WriteLine("Исходный массив:");
PrintArray(myArray);

int rows = myArray.GetLength(0);
int columns = myArray.GetLength(1);

for (int i = 0; i < columns; i++)
{
    int temp = myArray[0, i];
    myArray[0, i] = myArray[rows - 1, i];
    myArray[rows - 1, i] = temp;
}

Console.WriteLine("\nИзмененный массив:");
PrintArray(myArray);
    
    static void PrintArray(int[,] arr)
{
    int rows = arr.GetLength(0);
    int columns = arr.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

