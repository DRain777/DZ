// Напишите программу .которая принимает на вход 3 числа и выдает максимальное из этих чисел
Console.WriteLine("ВВедите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ВВедите второе число");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ВВедите третье число");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
if(b > a)
{
    max = b;
}    
if(c > b)
{
    max = c;
}
Console.WriteLine("Максимальное число: " + max);
