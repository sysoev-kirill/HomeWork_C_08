// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы (решил в старом стиле):




int[,] GetMatrix1(int row, int colum)
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

int[,] GetMatrix2(int[,] matrixResult1)
{
   int[,] matrix = new int[matrixResult1.GetLength(0), matrixResult1.GetLength(1)];
   Random rnd = new Random();
   for (int k = 0; k < matrix.GetLength(0); k++)
   {
      for (int n = 0; n < matrix.GetLength(1); n++)
      {
         matrix[k, n] = rnd.Next(1, 10);
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

int[,] ResultMatrix(int[,] matrixResult1, int[,] matrixResult2)
{
   int[,] matrix = new int[matrixResult1.GetLength(0), matrixResult1.GetLength(1)];


   for (int i = 0; i < matrix.GetLength(0); i++)
   {
      for (int j = 0; j < matrix.GetLength(1); j++)
      {
         matrix[i, j] = matrixResult1[i, j] * matrixResult2[i, j];
      }
   }
   return matrix;
}

Console.WriteLine();
Console.WriteLine("Матрица № 1");
int[,] matrixResult1 = GetMatrix1(2, 2);
PrintMatrix(matrixResult1);
Console.WriteLine();
Console.WriteLine("Матрица № 2");
int[,] matrixResult2 = GetMatrix2(matrixResult1);
PrintMatrix(matrixResult2);
Console.WriteLine();
Console.WriteLine("Результат вычисления.");
int[,] matrix = ResultMatrix(matrixResult1, matrixResult2);
PrintMatrix(matrix);