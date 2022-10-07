// Задача 48. Задать двумерный массив размером m на n, каждый элемент в массиве находится по формуле :А=i+j.
// Выведите полученный массив на экран.
// m=3 n=4
// 0 1 2 3 
// 1 2 3 4 
// 2 3 4 5  

Random random = new Random();
int rows = random.Next(5, 7);
int columns = random.Next(5, 7);
Console.WriteLine($"Размер данного массива {rows} х {columns}: ");
int[,] numbers = new int[rows, columns];
FillArray(numbers);
PrintArray(numbers);


void PrintArray(int[,] numbers)
{
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1); 
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(numbers[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] numbers)
{
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);   
    Random random = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            numbers[i, j] = i+j;
        }
    }
}
