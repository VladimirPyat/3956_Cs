// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.WriteLine("Введите число или 'stop' для окончания ввода: ");
string userNumber="";
int count=0;
while (true)
{
  userNumber=Console.ReadLine();
  if (userNumber.ToLower()!=("stop"))
  {
    if (Convert.ToInt32(userNumber)>0) count++;
  }  
  else break;
} 
Console.WriteLine("Число чисел больше 0 = "+count);