﻿// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int number=8;

void NaturalArray (int n)
{
  if (n==0) return ;
  else 
  {
    
    Console.Write(n+" ");
    NaturalArray(n-1);
  }
}

NaturalArray (number);
