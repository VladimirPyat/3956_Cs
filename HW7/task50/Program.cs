// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

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

int FindMatrixElement(int [,] matrix )
{
  int checkRow = 0;
  int checkColumn = 0;

    while (true)
    {
      checkRow = ReadNumber ("Укажите номер строки: ");
      if (checkRow >= matrix.GetLength(0)) 
      {Console.WriteLine("Нет такого номера");}
      else break;
    }
    while (true)
    {
      checkColumn = ReadNumber ("Укажите номер столбца: ");
      if (checkColumn >= matrix.GetLength(1)) 
      {Console.WriteLine("Нет такого номера");}
      else break;
    }    
    int value=matrix[checkRow,checkColumn];
    return value;
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

int m = ReadNumber("Введите количество строк:");
int n = ReadNumber("Введите количество столбцов:");
Console.WriteLine();
int[,] myMatrix = GetRandomMatrix(m, n);
PrintMatrix(myMatrix);
Console.WriteLine();

Console.WriteLine(FindMatrixElement(myMatrix));