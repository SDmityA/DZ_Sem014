// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// ***************Задача 1**********************************
// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// Console.WriteLine("Введите количество строк");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int col = Convert.ToInt32(Console.ReadLine());
// int[,] matrix= new int [row,col];
// int [,] Getarray()
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(0); j++)
//         {
//             matrix[i,j] = new Random().Next(10);   
//         }
//     }
//     return matrix;
// }

// void Printarray(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i,j]+":");
//         }
//         Console.WriteLine();
//     }
// }

// int [,] Changearray(int [,] matrix)
// {
//     int temp=0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//        for (int j = 0; j < matrix.GetLength(1); j++)
//        {
//         for (int k = 0; k < matrix.GetLength(1)-1; k++)
//         {
//             if (matrix[i,k]<matrix[i,k+1])
//             {
//                 temp=matrix[i,k+1];
//                 matrix[i,k+1]=matrix[i,k];
//                 matrix[i,k]=temp;
//             }
//         }
//        }
//     }
//     return matrix;
// } 

// Printarray(Getarray());
// Console.WriteLine();
// Printarray(Changearray(matrix));

// Эта задача сломала мне мозг!
// ********************Конец*****************************
// *******************Задача 2***************************
// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// int[,] matrix= new int [4,3];
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//             matrix[i,j] = new Random().Next(10);
//             Console.Write(matrix[i,j]+":");   
//     }
//     Console.WriteLine();
// }
// Console.WriteLine();
// int row = 0;
// int minsum=int.MaxValue;
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     int sum=0;
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         sum = sum+ matrix[i,j];
//     }
//     if (sum<minsum)
//     {
//         minsum = sum;
//         row=i+1;
//     }
//     // Console.WriteLine(sum);
//     // Console.WriteLine(minsum+"!");
// }
// Console.WriteLine("Номер строки с наименьшей суммой элементов: "+row+"*");

// *************Конец*************************************************
// ***********Задача 3**********************************************
// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
// int size=2;
// int [,] matrix1= new int [size,size];
// int [,] matrix2= new int [size,size];
// int [,] matrix3= new int [size,size];

// void Fillmatrix(int [,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 array [i,j] = new Random().Next(10);   
//         }
//     }
// }
// void Printarray (int [,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//          Console.Write(array[i,j]+":");   
//         }
//         Console.WriteLine();
//     }
// }
//     Fillmatrix(matrix1);
//     Printarray(matrix1);
//     Console.WriteLine();
//     Fillmatrix(matrix2);
//     Printarray(matrix2);
//     for (int i = 0; i < size; i++)
//     {
//         for (int j = 0; j < size; j++)
//         {
//             for (int k = 0; k < size; k++)
//             {
//                 matrix3[i,j]=matrix3[i,j]+(matrix1[i,k]*matrix2[k,j]);
//             }
//         }
//     }
//     Console.WriteLine("Произведение");
//     Printarray(matrix3);

// *****************Конец*********************
// **************Задача 4*********************
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// int size =2;
// int [,,] cube=new int [size,size,size];
// int [,,] cube2=new int [size,size,size];
// int temp=cube[0,0,0];
// for (int i = 0; i < size; i++)
// {
//     for (int j = 0; j < size; j++)
//     {
//         for (int k = 0; k < size; k++)
//         {
//             cube[i,j,k] = new Random().Next(10,100);
//             Console.Write(cube[i,j,k]+":"+"("+i+","+j+","+k+","+") ");

//         }
//         Console.WriteLine();
//     }
    
// }
// *****************Конец**************
// ****************Задача 5************
// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// int size = 4;
// int [,] matrix = new int [size,size];
// int temp=1;
// int i=0;
// int j=0;

// while (temp<=size*size)
// {
//     matrix[i,j]=temp;
//     temp++;
//     if (i <= j + 1 && i + j < size - 1)
//         ++j;
//     else if (i < j && i + j >= size - 1)
//         ++i;
//     else if (i >= j && i + j > size - 1)
//         --j;
//     else
//         --i;
        
// }
// Printarray(matrix);

// void Printarray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j] + ":");
//         }
//         Console.WriteLine();
//     }
// }
// ******************Конец*********************
