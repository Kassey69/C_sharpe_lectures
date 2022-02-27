// Задача 4 - Сложения двух чисел со случайными числами
int numberA = new Random().Next(1,10);
int numberB =new Random().Next(1,10);
int sum = numberA + numberB;
Console.WriteLine("Первое случайно число " + numberA);
Console.WriteLine("Второе случайное число " + numberB);
Console.WriteLine("Сложение двух случайных чисел " + numberA +" + " + numberB + " = " + sum);
