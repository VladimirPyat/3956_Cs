// Задание 2. Принимаем на вход два числа. Вывод - какое число больше, какое меньше

Console.Write("Number#1: ");
int number1=Convert.ToInt16(Console.ReadLine());
Console.Write("Number#2: ");
int number2=Convert.ToInt16(Console.ReadLine());
if (number1>number2)
{
Console.WriteLine("Maximum: "+number1);
Console.WriteLine("Minimum: "+number2);
}
else
{
Console.WriteLine("Maximum: "+number2);
Console.WriteLine("Minimum: "+number1); 
}