// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив,
// добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] Get3DMatrix(int row, int colum, int colum2)
{
   int num = 10;
   int[,,] matrix3D = new int[row, colum, colum2];
   for (int i = 0; i < matrix3D.GetLength(0); i++)
   {
      for (int j = 0; j < matrix3D.GetLength(1); j++)
      {
         for (int k = 0; k < matrix3D.GetLength(2); k++)
         {
            if (num < 99)
            {
               matrix3D[i, j, k] = num;
               num++;
            }
         }
      }
   }
   return matrix3D;
}

void Print3DMatrix(int[,,] array)
{
   for (int i = 0; i < array.GetLength(0); i++)
   {
      for (int j = 0; j < array.GetLength(1); j++)
      {
         for (int k = 0; k < array.GetLength(2); k++)
         {
            Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
         }
         Console.WriteLine();
      }
   }
}

int[,,] get3DMatrix = Get3DMatrix(2, 2, 2);
Print3DMatrix(get3DMatrix);
Console.WriteLine();