/*Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/

void FillSpiral(int[,] array, int size)
{
    int value = 1;
    int i = 0;
    int j = 0;
    while (value <= size * size)
    {
        array[i, j] = value;
        if (i <= j + 1 && i + j < size - 1)
        {
            ++j;
        }
        else if (i < j && i + j >= size - 1)
        {
            ++i;
        }
        else if (i >= j && i + j > size - 1)
        {
            --j;
        }
        else
        {
            --i;
        }
        ++value;
    }
}
void PrintArray(int[,] array, int size)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
            {
                System.Console.Write("0" + array[i, j]);
                System.Console.Write(" ");
            }
            else
            {
                System.Console.Write(array[i, j] + " ");
            }
        }
        System.Console.WriteLine();
    }
}
int size = 4;
int[,] array = new int[size, size];
FillSpiral(array, size);
PrintArray(array,size);
