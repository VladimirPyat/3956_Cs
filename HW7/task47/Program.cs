// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.​

int ReadNumber(string messageToUser)
{
    Console.WriteLine(messageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

double [,] RandomMatrixDouble (int rows, int columns, int leftBorder = -10, int rightBorder = 10, int decPlaces = 2) 
// задаем кол-во строк, столбцов, левую и правую границу, число знаков для округления 
{

    double [,] matrix = new double [rows, columns];

    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round(Random.Shared.NextDouble()*(rightBorder-leftBorder)+leftBorder, decPlaces);
        }
    }

    return matrix;
}

void PrintMatrixDouble (double[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write (matrix[i, j]+"\t"+"\t");
        }
        Console.WriteLine();
    }
}

int m = ReadNumber("Введите количество строк:");
int n = ReadNumber("Введите количество столбцов:");
double [,] myMatrix = RandomMatrixDouble (m, n);
PrintMatrixDouble (myMatrix);