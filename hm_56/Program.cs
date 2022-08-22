// ЗАДАЧА 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


Console.WriteLine("введите количество строк  ");
int len = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите  количество столбцов  ");
int high = Convert.ToInt32(Console.ReadLine());



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


void PrintArray(int[] array)
{
   for (int i = 0; i < array.Length; i++)
   {
      if (i == 0) Console.Write("[");
      if (i < array.Length - 1) Console.Write(array[i] + ", ");
      else Console.Write(array[i] + "]");
   }
   Console.WriteLine(" ");
}


int[] SumArray(int[,] array)
{
   int[] SumArray = new int[array.GetLength(0)];

   for (int row = 0; row < array.GetLength(0); row++)
   {
      int sum = 0;
      for (int column = 0; column < array.GetLength(1); column++)
      {
         sum += array[row, column];
      }
      SumArray[row] = sum;
   }

   return SumArray;
}

int FindMin(int[] array)
{
   int indexMin = 0;
   int min = array[indexMin];
   for (int i = 1; i < array.Length; i++)
   {
      if (array[i] < min)
      {
         min = array[i];
         indexMin = i;
      }
   }
   return indexMin + 1;
}

int[,] matrixResult = GetMatrix(len, high);
PrintMatrix(matrixResult);
Console.WriteLine();
Console.WriteLine("Суммы элементов в каждой строке");
int[] sumArray = SumArray(matrixResult);
PrintArray(sumArray);
Console.WriteLine();
int numOfRow = FindMin(sumArray);
Console.WriteLine($"Строка с наименьшей суммой элементов => {numOfRow}");