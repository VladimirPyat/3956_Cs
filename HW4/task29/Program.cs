//  Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран

void ArrayManualFill(int [] array)
{
  for (int i=0;i<array.Length;i++)
    {
      Console.Write(i+" :");
      array[i]=Convert.ToInt32(Console.ReadLine());
    }
}

Console.Write("введите число элементов массива: ");
int number=Convert.ToInt32(Console.ReadLine());
int[] myArray=new int [number];
ArrayManualFill(myArray);
Console.WriteLine("["+string.Join(", ", myArray)+"]");
