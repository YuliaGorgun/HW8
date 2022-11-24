// Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.

/*Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/


int[,] array = new int[,] {{1, 4, 7 ,2},
                        {5, 9, 2, 3},
                        {8, 4, 2, 4},
                        {5, 2, 6, 7}};

MinSumElementsArray(array);
PrintArray(array);

int minSumElements = 0;
int sumElements = SumElements(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
  int tempElements = SumElements(array, i);
  if (sumElements > tempElements)
  {
    sumElements = tempElements;
    minSumElements = i;
  }
}

Console.WriteLine($"\n{minSumElements+1} - строкa с наименьшей суммой ({sumElements}) элементов ");

int SumElements(int[,] array, int i)
{
  int sumElements = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumElements += array[i,j];
  }
  return sumElements;
}


void MinSumElementsArray(int[,] array,int minValue = 0, int maxValue = 10)
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