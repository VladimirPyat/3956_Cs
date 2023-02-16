// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

Console.Write ("число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write ("число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1%number2==0)
{
    Console.WriteLine("кратно");
}
else
{
   Console.WriteLine($"некратно, остаток= {number1%number2}"); 
}