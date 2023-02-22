// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B - без модуля Math
Console.Write("Введите число: ");
int num=Convert.ToInt32(Console.ReadLine());
Console.Write("В какую степень возвести?: ");
int pow=Convert.ToInt32(Console.ReadLine());
int result=1;
for (int i=1; i<=pow; i++)
{
  result=result*num;
}
Console.Write("Результат возведения в степень: "+result);