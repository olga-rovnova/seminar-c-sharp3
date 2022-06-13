//Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
//или сообщает, что третьей цифры нет.

Console.Write("введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int abs = Math.Abs(number); //модуль числа
int div = abs % 1000; //остаток от деления модуля на 1000

if (div > 99 && div < 1000)
{
    int numberThird = div / 100;
    Console.WriteLine("третяя цифра числа: " + numberThird);
}
else
{
    Console.WriteLine("в числе третьей цифры нет");
}
