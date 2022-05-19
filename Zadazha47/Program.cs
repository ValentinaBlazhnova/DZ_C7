/* Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/

Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] array = new double[m, n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j <n; j++)
    {
        double min = -10.0,  max = 10.0;
        array[i, j] = new Random().NextDouble() * (max - min) + min; // Для целых чисел: new Random().Next(-10, 10);
    }
}

for (int i = 0; i < m; i++)
{
    for (int j = 0; j <n; j++)
    {
        Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
}

