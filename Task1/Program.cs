// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

int rows = 3;
int columns = 4;
int[,] numbers = new int[rows, columns];
Random randomizer = new Random();

for(int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        numbers[i, j] = randomizer.Next(1, 10);
    }
}

PrintIntArray2D(numbers);

int ReadInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

void PrintIntArray2D(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }

    Console.WriteLine();
}