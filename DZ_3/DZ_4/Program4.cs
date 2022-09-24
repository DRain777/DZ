// Напишите программу которая на вход примет число и выдас является оно четным или нет
Console.WriteLine("Хочешь узнать четное ли число");
Console.WriteLine("Твое число");
int a = Convert.ToInt32(Console.ReadLine());
if( a % 2 == 0)
{
    Console.WriteLine("Твое число четное");
}
else
{
    Console.WriteLine(" Нечетное");
}