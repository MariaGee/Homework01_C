//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N
int numberA = new Random().Next(0, 100);
int count = 1;

Console.WriteLine("Было задано число: " + numberA);

while(count <= numberA)
{
    if (count % 2 == 0)
    {
        Console.Write(count + " ");
    }
    count++;
}
