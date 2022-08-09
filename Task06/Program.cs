//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
int numberA = new Random().Next(0, 100);

if (numberA % 2 == 0)
{
    Console.WriteLine("Число " + numberA + " является четным");
}
else
{
    Console.WriteLine("Число " + numberA + " является нечетным");
}