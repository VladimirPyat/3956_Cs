// задача 6. на вход число, вывод - четное или нет
Console.Write("Введите число: ");
double number = Convert.ToInt16(Console.ReadLine());
if (number%2==0)
{
    Console.WriteLine("четное");
}
else
{
    Console.WriteLine("НЕчетное");
}