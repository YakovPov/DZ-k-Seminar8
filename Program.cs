// _______________________________Задача 54:________________________________
// Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


// Console.WriteLine("Введите кол. строчек");
// int rows= Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите кол. колонок");
// int columns= Convert.ToInt32(Console.ReadLine());

// int [,] array = new int [rows,columns];

// void GetArray()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j]=new Random().Next(0,10);
//         }
//     }
// }

// void PrintArray()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j]);
//         }
//         Console.WriteLine();
//     }
// }

// void SortArray()
// {
//     int MaxArray = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int s = 0; s < array.GetLength(1) - 1; s++)
//             {
//                 if (array[i, s] < array[i, s + 1])
//                 {
//                     MaxArray = array[i, s + 1];
//                     array[i, s + 1] = array[i, s];
//                     array[i, s] = MaxArray;
//                 }
//             }
//         }
//     }
// }

// GetArray();
// PrintArray();
// SortArray();
// Console.WriteLine("");
// PrintArray();



// _____________________Задача 56:________________________________
// Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер 
// строки с наименьшей суммой элементов: 1 строка

// Console.WriteLine("Введите кол. строчек");
// int rows= Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите кол. колонок");
// int columns= Convert.ToInt32(Console.ReadLine());

// int [,] array = new int [rows,columns];

// void GetArray()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j]=new Random().Next(0,10);
//         }
//     }
// }

// void PrintArray()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j]+" ");
//         }
//         Console.WriteLine();
//     }
// }

// void MinRow()
// {
//     int row=0;
//     int min=int.MaxValue;
//     int result=0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//            result+=array[i,j];
//         }
//         if (result<min)
//         {
//             min=result;
//             row=i;
//         }
//         Console.WriteLine($"Сумма чисел в строке {i+1} = {result} ");
//         result -= result;
//     }
//     Console.WriteLine("");
//     Console.WriteLine($"Минимальное значение : {min}");
//     Console.WriteLine("");
//     Console.WriteLine($"Строка с минимальным значением : {row+1}");
// }

// GetArray();
// Console.WriteLine("");
// PrintArray();
// Console.WriteLine("");
// MinRow();
// Console.WriteLine("");


// _________________________Задача 58_______________________________
// Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


// Console.Write("Введите кол. строчек и колонок ");
// int rows = Convert.ToInt32(Console.ReadLine());
// int colomns = rows;

// int[,] array1 = new int[rows, colomns];
// int[,] array2 = new int[rows, colomns];
// int[,] result = new int[rows, colomns];

// void GetArray(int[,] result)
// {
//     for (int i = 0; i < result.GetLength(0); i++)
//     {
//         for (int j = 0; j < result.GetLength(1); j++)
//         {
//             result[i, j] = new Random().Next(0, 10);
//         }
//     }
// }

// void PrintArray(int[,] result)
// {
//     for (int i = 0; i < result.GetLength(0); i++)
//     {
//         for (int j = 0; j < result.GetLength(1); j++)
//         {
//             Console.Write($"{result[i, j]} ");
//         }
//         Console.WriteLine("");
//     }
// }

// void ProductArray(int[,] result)
// {
//     for (int i = 0; i < array1.GetLength(0); i++)
//     {
//         for (int j = 0; j < array2.GetLength(1); j++)
//         {
//             result[i, j] = 0;
//             for (int s = 0; s < array1.GetLength(1); s++)
//             {
//                 result[i, j] += array1[i, s] * array2[s, j];
//             }
//         }
//     }
// }

// GetArray(array1);
// PrintArray(array1);
// Console.WriteLine();
// GetArray(array2);
// PrintArray(array2);
// Console.WriteLine();
// ProductArray(result);
// PrintArray(result);


// ___________________________Задача 60_______________________________
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив,
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


// Console.Write("Введите количество строчек ");
// var rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество колонок ");
// var colomns = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество слоев ");
// var sloy = Convert.ToInt32(Console.ReadLine());

// int[,,] array = new int[sloy, rows, colomns];

// void GetArray()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int s = 0; s < array.GetLength(2); s++)
//             {
//                 array[i,j,s]=new Random().Next(10,99);
//             }

//         }
//     }
// }

// void PrintArray()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int s = 0; s < array.GetLength(2); s++)
//             {
//                 Console.Write($"{array[i, j, s]} ");
//             }
//             Console.WriteLine("");
//         }
//         Console.WriteLine("");
//     }
// }

// void PrintIndexArray()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int s = 0; s < array.GetLength(2); s++)
//             {
//                 Console.Write($"{array[i, j, s]}({i},{j},{s}) ");
//             }
//             Console.WriteLine("");
//         }
//         Console.WriteLine("");
//     }
// }

// GetArray();
// PrintArray();
// PrintIndexArray();


// _______________________Задача 62__________________________________
// Напишите программу, которая заполнит
// спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


int[,] array = new int[4,4];

int num = 1;
int i = 0;
int j = 0;

while (num <= 16)
{
 array[i, j] = num;
    if (i <= j + 1 && i + j < 4 - 1)
        ++j;
    else if (i < j && i + j >= 4 - 1)
        ++i;
    else if (i >= j && i + j > 4 - 1)
        --j;
    else
        --i;
    ++num;
}

PrintArray (array);

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}