//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

Console.Write("введите число от 1 до 7, обозначающее день недели: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 1 & number <= 7)
{
    if (number % 6 == 0 || number % 7 == 0)
    {
        Console.WriteLine("это выходной день");
    }
    else
    {
        Console.WriteLine("это рабочий день недели");
    }
}
else
{
    Console.WriteLine("введено некорректное число");
}