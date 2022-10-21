

/* 
Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
 */


float[,] Fill2DArrayWithRandomNumbers(float[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            inputArray[i, j] = new Random().Next(-100, 100);
            inputArray[i, j] /= 10;
        }
    }
    return inputArray;
}

void Print2DArray(float[,] inputArray)
{
    for (int rows = 0; rows < inputArray.GetLength(0); rows++)
    {
        for (int collums = 0; collums < inputArray.GetLength(1); collums++)
        {
            Console.Write($"{inputArray[rows, collums]} ");
        }
        Console.WriteLine();
    }
}





Console.Write("m: ");
int m = int.Parse(Console.ReadLine());
Console.Write("n: ");
int n = int.Parse(Console.ReadLine());
float[,] the2DArray = new float[n, m];


Print2DArray(Fill2DArrayWithRandomNumbers(the2DArray));