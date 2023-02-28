// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] GetRandomArray (int length, int leftRange, int rightRange)
{

  int[] array= new int[length];

  for (int i=0; i<array.Length;i++)
  {
    array[i]=new Random().Next(leftRange, rightRange + 1);
  }

  return array;
}

int[] ArrayPM = GetRandomArray (6, -50, 50);
Console.Write($"[{string.Join(", ", ArrayPM)}]");
int count=0;
for (int i=1;i<ArrayPM.Length;i+=2)
{
  count=count+ArrayPM[i];
  // Console.Write(i+" ");
}
// Console.WriteLine();
Console.Write(" -> "+count);