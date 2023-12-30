/*
//Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

int number = 323;


if (number % 7 == 0 && number % 23 == 0)
{
    Console.WriteLine($"Число `{number}` кратно одновременно 7 и 23");
}

else
{
    Console.WriteLine($"Число `{number}` не кратно одновременно 7 и 23");
}


//Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y),
//причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.

int X = 5;
int Y = -6;

if (X > 0 && Y > 0)
{
    Console.WriteLine($"Точка X = {X}, Y = {Y} находится в 1 четверти");
}
else if (X < 0 && Y > 0)
{
    Console.WriteLine($"Точка X = {X}, Y = {Y} находится в 2 четверти");
}
else if (X < 0 && Y < 0)
{
    Console.WriteLine($"Точка X = {X}, Y = {Y} находится в 3 четверти");
}
else
{
    Console.WriteLine($"Точка X = {X}, Y = {Y} находится в 4 четверти");
}
      

//Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.

int number = 91;

int tens = number / 10;
int ones = number % 10;

if(tens > ones)
{
    Console.WriteLine($"В числе {number} большая цифра - {tens}");
}
else if(ones > tens)
{
    Console.WriteLine($"В числе {number} большая цифра - {ones}");
}
else
{
    Console.WriteLine($"В числе {number} две одинаковые цифры - {tens}");
}

//Задача 4: Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.

internal class Program
{
    private static void Main(string[] args)
    {
        int N = 49559;

        while (N > 0)
        {
            int currentNumber = N % 10;
            Console.Write($"{currentNumber}, ");
            N = N / 10;
        }
    }
}
// Так и не понял как без масива вывести цифры в прямом порядке, а не в обратном. =(

*/

