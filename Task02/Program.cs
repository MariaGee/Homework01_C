//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее
int numberA = new Random().Next(0, 100);
int numberB = new Random().Next(0, 100);
int max = numberA;

Console.WriteLine("Были заданы следующие числа: " + numberA + " и " + numberB);

if (max < numberB)
{
    max = numberB;
    Console.Write("Число " + max + " больше числа " + numberA);
}
else if (max > numberB)
{
    Console.Write("Число " + max + " больше числа " + numberB);
}
else 
{
    Console.Write("Числа " + max + " и " + numberB + " равны");
}
