// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 
//(номер цифры считается от левого края)

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100)
{
    Console.Write("отсутствует 3я цифра");
}
else
{
  int number1=number;
    while (number1 > 999)
    {
        number1 = number1 / 10;
    }
    int result = number1 % 10;
    Console.WriteLine("Третья цифра= " + result);
}
