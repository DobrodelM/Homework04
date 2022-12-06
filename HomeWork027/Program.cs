/* Задача 27.
Напишите программу, которая принимает на вход число
и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

int GetNumberFromUser(string message)
{
int result = 0;
Console.WriteLine(message);
result = Convert.ToInt32(Console.ReadLine());
return result;
}

int SumOfNumber(int number)
{
int buf = 0;
int result = 0;
while(number > 0)
{
buf = number % 10;
result = result + buf;
number = number / 10;
}
return result;
}

int number = GetNumberFromUser("Введите число");
int sumOfNumber = SumOfNumber(number);
Console.WriteLine($"Сумма цифр числа {number} равна {sumOfNumber}");
