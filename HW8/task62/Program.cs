// Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:

// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7


int ReadNumber(string messageToUser)
{
  Console.WriteLine(messageToUser);
  int value = Convert.ToInt32(Console.ReadLine());
  return value;
}

void PrintMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
  }
}

int m = ReadNumber("Введите количество строк:");
int n = ReadNumber("Введите количество столбцов:");
int[,] myMatrix = new int[m, n];

int startX = 0;
int finishX = n - 1;
int startY = 0;
int finishY = m - 1;
int count = 1;

while (startX < finishX && startY < finishY)
{
  for (int j = startX; j <= finishX; j ++)
  {
    myMatrix[startY, j] = count;
    count++;
  }
  startY++;

  for (int i = startY; i <= finishY; i ++)
  {
    myMatrix[i, finishX] = count;
    count++;
  }
  finishX--;

  for (int j = finishX; j > startX-1; j --)
  {
    myMatrix[finishY, j] = count;
    count++;
  }
  finishY--;
  
  for (int i = finishY; i > startY-1; i --)
  {
    myMatrix[i, startX] = count;
    count++;
  }
  startX++;
  
}
if (n%2!=0 && m%2!=0) {myMatrix[m/2, n/2] = count;}

PrintMatrix(myMatrix);