

/* 
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет
 */



int[,] Fill2DArrayWithRandomNumbers(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            inputArray[i, j] = new Random().Next(-100, 100);
        }
    }
    return inputArray;
}

void Print2DArray(int[,] inputArray)
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

/* void CheckNIn2DArrayAcink(int[,] inputArray, int huntedNumber)
{
    bool numberInArray = false;

    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            if (inputArray[i, j] == huntedNumber) { numberInArray = true; };
        }
    }

    if (numberInArray == true) { Console.WriteLine($"{huntedNumber} -> такое число в массиве есть"); }
    if (numberInArray != true) { Console.WriteLine($"{huntedNumber} -> такого числа в массиве нет"); }
} */

void CheckNIn2DArrayAcink(int[,] inputArray, int huntedNumber)
{
    bool numberInArray = false;

    foreach (int item in inputArray)
    {
        if (item == huntedNumber)
        {
            numberInArray = true;
        }
    }

    if (numberInArray == true) { Console.WriteLine($"{huntedNumber} -> такое число в массиве есть"); }
    if (numberInArray != true) { Console.WriteLine($"{huntedNumber} -> такого числа в массиве нет"); }
}



int[,] the2DArray = new int[5, 8];
the2DArray = Fill2DArrayWithRandomNumbers(the2DArray);
Print2DArray(the2DArray);

Console.WriteLine("-----------------------------");

Console.Write("Искомое= ");
int huntedNumber = int.Parse(Console.ReadLine());

Console.WriteLine("-----------------------------");

CheckNIn2DArrayAcink(the2DArray, huntedNumber);