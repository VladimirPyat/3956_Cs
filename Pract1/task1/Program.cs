// 3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда 
// 5 -> Пятница
Console.Write("Введите номер дня недели 1-7: ");
int day_num = Convert.ToInt32(Console.ReadLine());
if (day_num == 1)
{
    Console.WriteLine("понедельник");
}
else if (day_num == 2)
{
    Console.WriteLine("вторник");
}
else if (day_num == 3)
{
    Console.WriteLine("среда");
}
else if (day_num == 4)
{
    Console.WriteLine("четверг");
}
else if (day_num == 5)
{
    Console.WriteLine("пятница");
}
else if (day_num == 6)
{
    Console.WriteLine("суббота");
}
else if (day_num == 7)
{
    Console.WriteLine("воскресенье");
}

else
{
    Console.WriteLine("неверный ввод");
}