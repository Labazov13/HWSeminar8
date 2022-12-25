/*Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

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

static int[,] MultyArray(int[,] array1, int[,] array2)
{
    int[,] multyArray = new int[array1.GetLength(1), array2.GetLength(0)];
        for (int i = 0; i < array2.GetLength(1); i++)
        {
            for (int j = 0; j < array2.GetLength(0); j++)
            {
                multyArray[i, j] = 0;
                for (int k = 0; k < array2.GetLength(0); k++)
                {
                    multyArray[i, j] += array1[i, k] * array2[k, j];
                }
            }
        }
    return multyArray;
}


int[,] array1 = GetArray();
int[,] array2 = GetArray();
PrintArray(array1);
System.Console.WriteLine();
PrintArray(array2);
int[,] multyArray = MultyArray(array1, array2);
System.Console.WriteLine();
PrintArray(multyArray);
