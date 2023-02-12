// задача 4. принять на вход три числа. найти максимум
Console.WriteLine("Введите 3 числа");
int number1=Convert.ToInt16(Console.ReadLine());
int number2=Convert.ToInt16(Console.ReadLine());
int number3=Convert.ToInt16(Console.ReadLine());
int max=number1;
if (number2>max)
{
    max=number2;
}
if (number3>max)
{
    max=number3;
}
Console.WriteLine("Максимум равен "+max);
