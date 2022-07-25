// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.

void Zadachs56()
{
    Random random = new Random();
    int rows = random.Next(4, 9);
    int columns = random.Next(4, 9);
    int[,] array = new int[rows, columns];

    Console.WriteLine("Вывод массива: ");
    FillArray(array);
    PrintArray(array);
    MaxSum(array);
}

void FillArray(int[,] array)
{
    Random random = new Random();
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = random.Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void MaxSum(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    int max = 0;
    int temp = 0;

    for (int i = 0; i < rows; i++)
    {
        int sum = 0;
        for (int j = 0; j < columns; j++)
        {
            sum = sum + array[i, j];
        }
        Console.WriteLine($"Сумма эллементов {i} строки равна {sum}");
        if (max < sum)
        {
            max = sum;
            temp = i;
        }
    }
    Console.WriteLine($"Строка {temp} имеет наибольшую сумму элементов равную {max}");

}

Zadachs56();