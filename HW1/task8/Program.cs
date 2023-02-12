// задача8. на входе целое число, на выходе все чётные числа от 1 до n
Console.Write("Введите число: ");
int number = Convert.ToInt16 (Console.ReadLine());
for (int i=2;i<=number;i++)
{
    if (i%2==0) 
    {
        Console.Write(i+" ");
    }
}