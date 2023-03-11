// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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

void PrintMatrixProduct (int[,] matrix1, int[,] matrix2)
{
    for(int i = 0; i < matrix1.GetLength(0); i++)
    {
        for(int j = 0; j < matrix1.GetLength(1); j++)
        {
            Console.Write(matrix1[i, j]*matrix2[i, j] + " ");
        }
        Console.WriteLine();
    }
}


int m = ReadNumber("Введите количество строк:");
int n = ReadNumber("Введите количество столбцов:");
int[,] myMatrix1 = GetRandomMatrix(m, n);
int[,] myMatrix2 = GetRandomMatrix(m, n);
PrintMatrix(myMatrix1);
Console.WriteLine();
PrintMatrix(myMatrix2);
Console.WriteLine();
PrintMatrixProduct (myMatrix1, myMatrix2);


