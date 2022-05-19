/* Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает 
значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/


int rows = 4;
int columns = 4;
int[,] array = new int[rows, columns];

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j <columns; j++)
    {
        array[i, j] = new Random().Next(0, 20);
    }
}

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j <columns; j++)
    {
        Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("Введите номер строки для проверки: ");
int inputRows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца для проверки: ");
int inputColumns = Convert.ToInt32(Console.ReadLine());

if(inputRows <= rows && inputColumns <= columns)
{
    Console.WriteLine($"Этой позиции принадлежит число {array[inputRows-1, inputColumns-1]}");
}
else
{
    Console.WriteLine("Такого числа в массиве нет");
}

