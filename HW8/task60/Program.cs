// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента. массив размером 2 x 2 x 2

void PrintArray3D (int[,,] array3D)
{
  for (int i=0; i<array3D.GetLength(0);i++)
  {
    for (int j=0; j<array3D.GetLength(1);j++)
    {
      for (int k=0; k<array3D.GetLength(2);k++)
      {
        Console.Write ($"{array3D[i,j,k]}({i}, {j}, {k} ) ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}


int[,,] myArray3D = new int[,,] 
{ 
  { { 1, 2}, { 3, 4 }}, 
  { { 5, 6}, { 7, 8 }}
};

PrintArray3D (myArray3D);