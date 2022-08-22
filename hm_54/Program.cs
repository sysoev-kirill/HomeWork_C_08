
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8




int[,] GetMatrix(int row, int colum)
{
   int[,] matrix = new int[row, colum];
   Random rnd = new Random();
   for (int i = 0; i < matrix.GetLength(0); i++)
   {
      for (int j = 0; j < matrix.GetLength(1); j++)
      {
         matrix[i, j] = rnd.Next(1, 10);
      }
   }
   return matrix;
}


void PrintMatrix(int[,] array)
{

   for (int i = 0; i < array.GetLength(0); i++)
   {
      for (int j = 0; j < array.GetLength(1); j++)
      {
         if (j == 0) Console.Write("[");
         if (j < array.GetLength(1) - 1) Console.Write($"{array[i, j],3},");
         else Console.Write($"{array[i, j],3}]");
      }
      Console.WriteLine();
   }
}



int[,] SortMatrix(int[,] matrix)
{
   int temp1;
   int temp2;
   for (int i = 0; i < matrix.GetLength(0); i++)
   {
      bool Sort = true;
      while (Sort)
      {
         Sort = false;
         for (int j = 0; j < matrix.GetLength(1) - 1; j++)
         {
            temp1 = matrix[i, j];
            temp2 = matrix[i, j + 1];
            if (temp1 < temp2)
            {
               matrix[i, j] = temp2;
               matrix[i, j + 1] = temp1;
               Sort = true;
            }
         }
      }
   }

   return matrix;
}


int[,] marixResult = GetMatrix(4, 4);
PrintMatrix(marixResult);
Console.WriteLine();

int[,] result = SortMatrix(marixResult);
PrintMatrix(result);
