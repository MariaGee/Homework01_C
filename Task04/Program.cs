//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
int numberA = new Random().Next(0, 100);
int numberB = new Random().Next(0, 100);
int numberC = new Random().Next(0, 100);
int max = numberA;

Console.WriteLine("Были заданы числа: " + numberA + ", " + numberB + ", " + numberC);

if (max < numberB)
{
    max = numberB;
}
else if (max < numberC)
{
    max = numberC;
}

Console.WriteLine("Самое большое число: " + max);
