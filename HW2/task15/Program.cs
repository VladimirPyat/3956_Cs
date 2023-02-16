// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
int dayNumber=0;
while (dayNumber<1||dayNumber>7)
{ 
    Console.Write("Введите номер дня недели (1-7): ");
    dayNumber=Convert.ToInt32(Console.ReadLine());
}
if (dayNumber==6||dayNumber==7)
{
  Console.WriteLine("выходной");
}
else
{
  Console.WriteLine("рабочий");
}