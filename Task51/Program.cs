// Задача 51. Задайте двумерный массив. найдите сумму элементов, находящихся на главной диагонали, 
// с индексами 0,0  1,1  2,2и т д.


Random random = new Random();
int rows = random.Next(5,6);
int columns = random.Next(5,6);
int[,] numbers = new int[rows, columns];
Console.WriteLine($"Размер данного массива {rows} х {columns}: ");

FillArray(numbers);

SummNumbers(numbers);
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
void SummNumbers(int[,] numbers)
{
    int sum = 0;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if (i == j) 
            {
                sum = sum + numbers[i,j];
            }
        }
    }
    Console.WriteLine("Сумма элементов массива по главной диагонали = " + sum);
}
