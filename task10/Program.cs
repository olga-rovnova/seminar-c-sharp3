//Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.

Console.Write("введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int abs = Math.Abs(number);
if (abs > 99 && number < 1000)
{
    int result1 = abs / 10;
    int result = result1 % 10;
    Console.WriteLine("вторая цифра числа: " + result);
}
else
{
    Console.WriteLine("число не является трехзначным");
}