/*Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию
 элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/

int[,] SortArray1(int[,] array)
{
    int temp = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) ; j++)
        {
            for (int n = 0; n < array.GetLength(0) - 1; n++)
            {
                if (array[j, n] < array[j, n + 1])
                {
                    temp = array[j, n];
                    array[j, n] = array[j, n + 1];
                    array[j, n + 1] = temp;
                }
            }
        }
    }
    return array;
}

int[,] GetArray()
{
    System.Console.Write("Введите количество строк: ");
    int rows = int.Parse(Console.ReadLine()!);
    System.Console.Write("Введите количество столбцов: ");
    int columns = int.Parse(Console.ReadLine()!);
    int[,] array = new int[rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

int[,] array = GetArray();
PrintArray(array);
System.Console.WriteLine();
SortArray1(array);
PrintArray(array);

