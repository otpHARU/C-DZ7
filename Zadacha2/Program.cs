// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] array = new int[rows, columns];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(0, 100);
        Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine();

Console.Write("Введите число для поиска: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

bool f = false;

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if ((number == array[i, j]))
        {
            rows = i;
            columns = j;
            f = true;
        }
        Console.Write("{0}\t", array[i, j]);
    }
    Console.WriteLine();
}
Console.WriteLine();
if (f)
    Console.WriteLine($"Число найдено — строка {rows + 1}, столбец {columns + 1}");
else
    Console.WriteLine("Число в массиве не найдено");



    