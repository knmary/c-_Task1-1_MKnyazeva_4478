//Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3
Console.WriteLine("Введите число №1");
string inputstring1 = Console.ReadLine();
int number1 = Convert.ToInt32(inputstring1);
Console.WriteLine("Введите число №2");
string inputstring2 = Console.ReadLine();
int number2 = Convert.ToInt32(inputstring2);

if (number1 > number2)
{
Console.WriteLine("Maximum number is " + number1);
Console.WriteLine("Minimum number is " + number2);
}
else 
{
Console.WriteLine("Maximum number is " + number2);
Console.WriteLine("Minimum number is " + number1);    
}