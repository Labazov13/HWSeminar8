/*Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

void MinSumRows(int[,] array)
{
    int[] sumRows = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumRows[i] += array[i, j];
            
        }
        System.Console.Write(sumRows[i]+" ");
    }   //45,11,23,7
    int minRows = sumRows[0];
    int index=0;
    int indexOfMinRows=0;
    for (int k = 0; k < sumRows.Length; k++)
    {
        if (minRows > sumRows[k])
        {
            minRows = sumRows[k];
            index=k;
            
        }
    }
    indexOfMinRows=index+1;
    System.Console.WriteLine("Минимальная строка: " + indexOfMinRows+"-я");

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
MinSumRows(array);
System.Console.WriteLine();

//18
//23
//18
//13