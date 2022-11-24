// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

/*Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

//2*3+4*3       2*4+4*3        18  20
//3*3 + 2*3     3*4 + 2*3      15  18



Console.WriteLine("Введите число строк 1-й матрицы: ");
int m = int.Parse (Console.ReadLine()!);
Console.WriteLine("Введите число столбцов 1-й матрицы (и строк 2-й): ");
int n = int.Parse (Console.ReadLine()!);
Console.WriteLine("Введите число столбцов 2-й матрицы: ");
int p = int.Parse (Console.ReadLine()!);
Console.WriteLine("Введите диапазон случайных чисел: от 1 до ");
int range = int.Parse (Console.ReadLine()!);

int[,] firstArray = new int[m, n];
CreateArray(firstArray);
Console.WriteLine($"\nПервая матрица:");
PrintArray(firstArray);

int[,] secondArray = new int[n, p];
CreateArray(secondArray);
Console.WriteLine($"\nВторая матрица:");
PrintArray(secondArray);

int[,] resultArray = new int[m,p];

MultiplicationOfTwoMatricesArray(firstArray,secondArray , resultArray);
Console.WriteLine($"\nПроизведение первой и второй матриц:");
PrintArray(resultArray);

void MultiplicationOfTwoMatricesArray(int[,] firstArray, int[,] secondArray, int[,] resultArray)
{
  for (int i = 0; i < resultArray.GetLength(0); i++)
  {
    for (int j = 0; j < resultArray.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstArray.GetLength(1); k++)
      {
        sum += firstArray[i,k] * secondArray[k,j];
      }
      resultArray[i,j] = sum;
    }
  }
}

void CreateArray(int[,] array, int minValue = 0, int maxValue = 10)
{
  var rnd = new Random(); 
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = rnd.Next(minValue, maxValue + 1);
    }
  }
}

void PrintArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}