// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
//по возрастанию элементы каждой строки двумерного массива.

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

void SortMatrixStrings (int[,] matrix)
{
  int rows = matrix.GetLength(0);
  int columns = matrix.GetLength(1);
  for (int i=0; i<rows; i++)
  {
    
    for (int j=0; j<columns; j++)
    {
      int temp=0;
      int min=j;
      for (int k=j; k<columns; k++)
      {
        if (matrix[i,k]<matrix[i,min]) min=k;
      }
      temp=matrix[i,j];
      matrix[i,j]=matrix[i,min];
      matrix[i,min]=temp;

    }
  }
  
}


int m = ReadNumber("Введите количество строк:");
int n = ReadNumber("Введите количество столбцов:");
int[,] myMatrix = GetRandomMatrix(m, n);
PrintMatrix(myMatrix);
Console.WriteLine();

SortMatrixStrings (myMatrix);

PrintMatrix(myMatrix);

