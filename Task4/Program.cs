/*Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

23:06
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12*/

int rows = 3;
int columns = 4;
int[,] numbers = new int[rows, columns];
Random randomizer = new Random();
int sum = 0;

FillIntArray2DRandomNumbers(numbers, randomizer);
PrintIntArray2D(numbers);

for(int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        if(i == j)
        {
            sum += numbers[i, j];
            break;
        }
    }
}

Console.WriteLine(sum);

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
/*
int rows = 4;
int columns = 4;
int[,] numbers = new int[rows, columns];
Random randomizer = new Random();
int sum = 0;

FillIntArray2DRandomNumbers(numbers, randomizer);
PrintIntArray2D(numbers);

int length = numbers.GetLength(0);
if(numbers.GetLength(1) < length)
    length = numbers.GetLength(1);

for(int i = 0; i < length; i++)
{
    sum += numbers[i, i];
}

Console.WriteLine(sum);

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
*/




