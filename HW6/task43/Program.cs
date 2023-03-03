// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
int ReadNumber(string messageToUser)
{
    Console.Write(messageToUser);
    return Convert.ToInt32(Console.ReadLine());
}

(double, double) CrossPoint (double a, double b, double c, double d)
{
    double x = (d - c)/(a - b);
    double y = a * (d - c) / (a - b) + c; 
    return (x, y);
}

Console.WriteLine("Ввод коэффициентов уравнения вида y = kx + b");
int k1=ReadNumber("Ввод k1: ");
int b1=ReadNumber("Ввод b1: ");
int k2=ReadNumber("Ввод k2: ");
int b2=ReadNumber("Ввод b2: ");

if (k1!=k2)
{
   (double x, double y) = CrossPoint (k1, k2, b1, b2);
   Console.WriteLine($"Координаты точки пересечения: ({x}, {y})");
}
else {Console.WriteLine("Прямые не пересекаются");}