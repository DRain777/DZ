// Напишите программу которая на входе принимает 2 числа и выдает,
// какочисло больше какое меньше.
Console.WriteLine("Первое число ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("второе число ");
int b = Convert.ToInt32(Console.ReadLine());
if(a > b)
{
    Console.WriteLine("Максимальное число: " +  a );
}
else 
{
     Console.WriteLine("Максимальное число: " +  b );
}


