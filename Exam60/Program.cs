/*Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
 Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/

int[,,] FillArray()
{
    System.Console.Write("Введите количество страниц: ");
    int page = int.Parse(Console.ReadLine()!);
    System.Console.Write("Введите количество строк: ");
    int row = int.Parse(Console.ReadLine()!);
    System.Console.Write("Введите количество столбцов: ");
    int column = int.Parse(Console.ReadLine()!);
    System.Console.Write("Введите минимальный элемент массива: ");
    int min = int.Parse(Console.ReadLine()!);
    System.Console.Write("Введите максимальный элемент массива: ");
    int max = int.Parse(Console.ReadLine()!);

    int[,,] array = new int[page, row, column];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int t = 0; t < array.GetLength(2); t++)
            {
                array[i, j, t] = new Random().Next(min, max + 1);
                if (t >= 1)
                {
                    while (array[i, j, t] == array[i, j, t - 1])
                    {
                        array[i, j, t] = new Random().Next(min, max + 1);
                    }
                }
            }
        }
    }
    return array;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.WriteLine("Страница " + (i + 1));
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int t = 0; t < array.GetLength(2); t++)
            {
                System.Console.Write(array[i, j, t] + $"({i},{j},{t})");
                System.Console.WriteLine();
            }
            System.Console.WriteLine();
        }

    }
}

int[,,] array = FillArray();
PrintArray(array);


