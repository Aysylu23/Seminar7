/*Задайте двумерный массив. Найдите элементы, у которых оба индекса нечётные, и замените эти элементы на их квадраты.

Например, изначально массив выглядел вот так:
1 4 7 2
5 9 2 3
8 4 2 4
Новый массив будет выглядеть вот так:
1 4 7 2
5 81 2 9
8 4 2 4*/

int rows = 3;
int columns = 4;
int[,] numbers = new int[rows, columns];
Random randomizer = new Random();

FillIntArray2DRandomNumbers(numbers, randomizer);
PrintIntArray2D(numbers);

for(int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        if(i % 2 != 0 && j % 2 != 0)
            numbers[i, j] *= numbers[i, j];
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

void FillIntArray2DRandomNumbers(int[,] array, Random randomizer)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = randomizer.Next(0, 10);
        }
    }
}