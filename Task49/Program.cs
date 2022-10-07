// Задача 49. Задайте двумерный массив. Найдите элементы, у которых оба индекса четные и 
// замените эти элементы на их квадраты.  


Random random = new Random();
int rows = random.Next(4,6);
int columns = random.Next(4,6);
int[,] numbers = new int[rows, columns];
Console.WriteLine($"Размер данного массива {rows} х {columns}: ");

FillArray(numbers);
PrintArray(numbers);

ChangeNumbers(numbers);
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
            numbers[i, j] = random.Next(0, 10);
        }
    }
}
void ChangeNumbers(int[,] numbers)
{
    for (int i = 0; i < rows; i+=2)
    {
        for (int j = 0; j < columns; j+=2)
        {
            numbers[i,j] = numbers[i,j] * numbers[i,j];
        }
    Console.WriteLine();
    }
}