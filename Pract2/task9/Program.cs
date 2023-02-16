// случайное число от 10 до 99, вывести макс цифру
int number = Random.Shared.Next(10, 100);
Console.WriteLine(number);
int lastDigit = number%10;
int firstDigit = number/10;
if (firstDigit > lastDigit)
{
    Console.WriteLine ($"max {firstDigit} min {lastDigit}");
}
else
{
    Console.WriteLine ($"max {lastDigit} min {firstDigit}");
}