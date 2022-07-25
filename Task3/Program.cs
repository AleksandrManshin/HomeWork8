// Задача 58. Заполните спирально массив 4 на 4.

void Zadachs58()
{
    Random random = new Random();
    int rows = 4;
    int columns = 4;
    int[,] array = new int[rows, columns];

    Console.WriteLine("Вывод массива: ");
    FillArray(array);
    PrintArray(array);
}

void FillArray(int[,] array)
{
    Random random = new Random();
    int number = Convert.ToInt32(random.Next(1, 16));
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    int i =0;
    int j = 0;

    for(j = 0; j < columns; j++)
    {
        array [i, j] = number;
        number--;
    }

   j = 3;
   for(i = 1; i < rows; i++)
   {
        array [i, j] = number;
        number--;
    }

    i = 3;
    for(j = 2; j >= 0; j--)
    {
       array [i, j] = number;
        number--; 
    }

    j = 0;
    for(i = 2; i > 0; i--)
    {
        array [i, j] = number;
        number--; 
    }

    i = 1;
    for(j = 1;j < 3; j++)
    {
        array [i, j] = number;
        number--; 
    }

    i = 2;
    for(j = 2;j > 0; j--)
    {
        array [i, j] = number;
        number--;
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


Zadachs58();