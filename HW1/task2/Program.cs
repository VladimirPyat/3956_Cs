// Задание 2. Принимаем на вход два числа. Вывод - какое число больше, какое меньше

Console.Write("Number#1: ");
int number1=Convert.ToInt16(Console.ReadLine());
Console.Write("Number#2: ");
int number2=Convert.ToInt16(Console.ReadLine());
if (number1>number2)
{
Console.Write("Maximum: ");
Console.WriteLine(number1);
Console.Write("Minimum: ");
Console.WriteLine(number2);
}
else
{
Console.Write("Maximum: ");
Console.WriteLine(number2);
Console.Write("Minimum: ");
Console.WriteLine(number1); 
}