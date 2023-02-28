// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
double[] GetRandomArrayD(int length, double leftRange, double rightRange)
{
  double[] array = new double[length];

  for (int i = 0; i < array.Length; i++)
  {
    int roundAmount = 0;
    array[i] = Math.Round((new Random().NextDouble()) * (rightRange - leftRange) + leftRange, roundAmount);
  }

  return array;
}

(double, double) FindMinMax (double[] array)
{
double max=array[0];
double min=array[0];
for (int i = 1; i < array.Length; i++)
{
  if (array[i]>max) max=array[i];
  if (array[i]<min) min=array[i];
}
return (max, min);
}

double[] myArrayD = GetRandomArrayD (8, -10, 10);
Console.Write(string.Join(" ", myArrayD));
(double maxArray, double minArray) = FindMinMax (myArrayD);
Console.Write ($" -> {maxArray-minArray}");