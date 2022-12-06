/* Задача 25: Напишите цикл,
который принимает на вход два числа (A и B)
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

int GetNumberFromUser(string message)
{
int result = 0;
Console.WriteLine(message);
result = Convert.ToInt32(Console.ReadLine());
return result;
}
int DegreeOfNumber(int number1, int number2)
{
int deg = 1;
for(int i = 1; i <= number2; i++)
{
deg = deg * number1;
}
return deg;
}

int numberA = GetNumberFromUser("Введите число A: ");
int numberB = GetNumberFromUser("Введите число B: ");
int degree = DegreeOfNumber(numberA, numberB);
Console.WriteLine($"Число {numberA} в степени {numberB} равно {degree}");
