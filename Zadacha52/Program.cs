/* Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3*/

Console.Write("Введите m(строки): ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n(столбцы): ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j <n; j++)
    {
        array[i, j] = new Random().Next(0, 10) ;
    }
}
PrintArray(array);

double[] sumArray = new double[n];

for (int j = 0; j < n; j++) 
{
    sumArray[j] = 0;
    for (int i = 0; i < m; i++)
    {
           
           sumArray[j] += array[i, j];
    }
    sumArray[j] /= m;
}
PrintSumArray(sumArray);

void PrintArray(int[,] array) 
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(array[i, j] + " "); 
        }
        Console.WriteLine(); 
    }
}

void PrintSumArray(double[] sumArray)
{
    for (int i = 0; i < n; i++)
    {
    Console.Write(Math.Round(sumArray[i], 1) + " ");
    }
}

