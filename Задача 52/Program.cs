


/* Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 
4,6; 5,6; 3,6; 3.
 */


float[,] Fill2DArrayWithRandomNumbers(float[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            inputArray[i, j] = new Random().Next(-10, 10);
            //inputArray[i, j] /= 10;
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

float MidSummInCollum2dArray(float[,] inputArray, int theCollum)
{
    float midSumm = 0;

    for (int rows = 0; rows < inputArray.GetLength(0); rows++)
    {
        midSumm += inputArray[rows, theCollum];
    }

    midSumm /= inputArray.GetLength(0);

    return midSumm;
}


float[,] the2DArray = new float[4, 4];
the2DArray = Fill2DArrayWithRandomNumbers(the2DArray);
Print2DArray(the2DArray);

Console.WriteLine("-----------------------------");

Console.WriteLine("Среднее арифметическое каждого столбца:");
Console.WriteLine($"{MidSummInCollum2dArray(the2DArray, 0)}; {MidSummInCollum2dArray(the2DArray, 1)}; {MidSummInCollum2dArray(the2DArray, 2)}; {MidSummInCollum2dArray(the2DArray, 3)};");
int huntedNumber = int.Parse(Console.ReadLine());