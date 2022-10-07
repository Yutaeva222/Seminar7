// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив
//  выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Новый массив будет выглядеть
// вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4

int InputNumber(string text) // Ручной ввод числа
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

string StringArray2(int[,] array, string split) // Преобразование массива в строку с заданным разделителем
{
    int length0 = array.GetLength(0); // получение длины массива
    int length1 = array.GetLength(1); // получение длины массива
    string textarray = String.Empty; // обнуление строки
    for (int i = 0; i < length0; i++) // цикл по всем элементам массива
    {
        for (int j = 0; j < length1; j++)
        {
            textarray += array[i, j]; // добавление в строку значение текущего элемента массива
            if (j < length1 - 1) // проверка является ли элемент последним (нужно ли добавлять разделитель в строку)
                textarray += split; // добавление разделителя между элементами в строку
        }
        textarray += "\n";
    }
    return textarray; // возврат значения элементов массива в виде полученной строки
}

void FillArray(int[,] array, int min, int max)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(min, max + 1);
}

void ArrayChange(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            if ((i+1) % 2 == 0 && (j+1) % 2 == 0)
                array[i, j] *= array[i, j];
}

int m = InputNumber("Введите первую размерность массива: "),
    n = InputNumber("Введите вторую размерность массива: "),
    min = InputNumber("Введите минимальное значение случайных чисел: "),
    max = InputNumber("Введите максимальное значение случайных чисел: ");
int[,] array = new int[m, n];

FillArray(array, min, max);
Console.WriteLine(StringArray2(array, ", "));
Console.WriteLine();
ArrayChange(array);
Console.WriteLine(StringArray2(array, ", "));
