// Задача 54: Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой строки двумерного массива.

void Zadachs54()
{
     Random random = new Random();
    int rows = random.Next(4, 9);
    int columns = random.Next(4, 9);
    int [,] array = new int [rows, columns];
   
   Console.WriteLine("Вывод массива: ");
    FillArray(array);
    PrintArray(array);
    SelectionSort(array);
    Console.WriteLine();
    Console.WriteLine("Отсортированный массив: ");
    PrintArray(array);
}

void FillArray(int [,] array)
{
    Random random = new Random();
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            array [i, j] = random.Next(1, 10);
        }
    }
}

void PrintArray(int [,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            Console.Write(array [i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void SelectionSort(int [,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    for(int i = 0; i < rows; i++)
    { 
        for(int j = 0; j < columns - 1; j++)
        {
            int maxPosition = j;
            for(int k = j + 1; k < columns; k++ )
            {
            if(array [i,k] > array[i, maxPosition]) maxPosition = k;
            }
            int temp = array[i,j];
            array [i,j] = array [i, maxPosition];
            array [i, maxPosition] = temp;
        }
    }

}

Zadachs54();