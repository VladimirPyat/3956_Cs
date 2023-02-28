// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] GetRandomArray (int length, int leftRange, int rightRange)
{

  int[] array= new int[length];

  for (int i=0; i<array.Length;i++)
  {
    array[i]=new Random().Next(leftRange, rightRange + 1);
  }

  return array;
}

int[] Array3 = GetRandomArray (6, 100, 999);
Console.Write($"[{string.Join(", ", Array3)}]");
int count=0;
for (int i=0;i<Array3.Length;i++)
{
  if (Array3[i]%2==0) count++;
}
Console.Write(" -> "+count);