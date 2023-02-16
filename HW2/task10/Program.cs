// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
int number=0;
while (number<100||number>999)
{ 
    Console.Write("Введите трехзначное число: ");
    number=Convert.ToInt32(Console.ReadLine());
}
int result=(number/10)%10;
Console.WriteLine("Вторая цифра="+result);