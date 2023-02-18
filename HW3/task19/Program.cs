// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

int number = 0;
while (number >= 100000 || number <= 9999)
{
  Console.Write("Введите 5-значное число: ");
  number = Convert.ToInt32(Console.ReadLine());
}
int direct = number;
int reverse = 0;
for (int i = 1; i <= 5; i++)
{
  reverse = reverse + direct % 10;
  direct = direct / 10;
  if (i < 5)
  {
    reverse = reverse * 10;
  }
}
Console.WriteLine($"{number} <-> {reverse}");
if (number == reverse)
{
  Console.WriteLine ($"Число {number} - палиндром");
}
else
{
  Console.WriteLine ($"Число {number} - НЕ палиндром");
}