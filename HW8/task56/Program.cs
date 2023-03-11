// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку 
//с наименьшей суммой элементов.

int ReadNumber(string messageToUser)
{
    Console.WriteLine(messageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int[,] GetRandomMatrix(int rows, int columns, int leftBorder = 0, int rightBorder = 10)
{

    int[,] matrix = new int[rows, columns];

    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Random.Shared.Next(leftBorder, rightBorder + 1);
        }
    }

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int [] StringSumm (int[,] matrix)
{
  int [] sum = new int [matrix.GetLength(0)];
  for (int i=0; i<matrix.GetLength(0);i++)
  {
    for (int j=0; j<matrix.GetLength(1);j++)
    {
      sum[i]+=matrix[i,j];
    }
   Console.WriteLine(sum[i]);
  }
  
  return sum;
}

int ArrayMin (int [] getArray)
{
  int minPosition=0;
  for (int i=1; i<getArray.GetLength(0); i++)
  {
    if (getArray[i]<getArray[minPosition]) minPosition=i;
  }
  return minPosition;
}

int m = ReadNumber("Введите количество строк:");
int n = ReadNumber("Введите количество столбцов:");
int[,] myMatrix = GetRandomMatrix(m, n);
PrintMatrix(myMatrix);
Console.WriteLine();

int[] myMatrixSumms = StringSumm (myMatrix);
int myMatrixMin = ArrayMin (myMatrixSumms);

Console.WriteLine ("Строка с минимальной суммой элементов - "+ myMatrixMin);
