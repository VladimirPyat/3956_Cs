// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
int ReadNumber(string message2user)
{
  Console.Write (message2user);
  int value = Convert.ToInt32(Console.ReadLine());
  return value;
}

int xa = ReadNumber("Введите координату X первой точки: ");
int ya = ReadNumber("Введите координату Y первой точки: ");
int za = ReadNumber("Введите координату Z первой точки: ");
int xb = ReadNumber("Введите координату X второй точки: ");
int yb = ReadNumber("Введите координату Y второй точки: ");
int zb = ReadNumber("Введите координату Z второй точки: ");

double length=Math.Sqrt(Math.Pow (xa-xb,2)+Math.Pow (ya-yb,2)+Math.Pow (za-zb,2));
Console.WriteLine("Расстояние="+Math.Round(length, 2));