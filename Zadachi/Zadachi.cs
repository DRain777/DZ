
void Zadach_0()
{
//Вести число N и показать все четные числа от 0 до N
Console.WriteLine("Введи Число");
int n = Convert.ToInt32(Console.ReadLine());
int number = 2;
while(number <= n)
{
    Console.Write(number + " " );
    number += 2;
} 
}   
 
void Zadacha_1()
{
// Напишите программу которая выводит случайное число { 10 ; 99} и показывает наибольшую цифру чиисла
Random random = new Random();
int number = random.Next(10, 100);
Console.WriteLine(number);
int tens = number / 10;
int ones = number % 10;
Console.WriteLine(tens);
Console.WriteLine(ones); 
if(tens > ones)
{
    Console.Write(tens +  " Наибольшее число");
}
else
{
    Console.Write(ones +   "Наибольшее Число "); 
}       
}
void Zadach_2()
{
 // Напишите программу которая выводит случайное трехзначное число . и удаляет 2 цифру этого числа.
 Random random = new Random();
 int numbers = random.Next(100, 200);
 Console.WriteLine(numbers);
 int handrid = numbers / 100;
 int tens = numbers / 10;
 int ones = numbers % 10;
 Console.Write($"{handrid}{ones}");
}
void Zadacha_3()
{ 
// Напишите программу которая будет принимать на входе 2 числа и ВЫВОДИТЬ является ли второе число  кратным 
// первому .Усли  число 2  не кратно числу 1 . то программа выводит остаток от деления.
Console.WriteLine("Введи первое  Число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи второе Число");
int num2 = Convert.ToInt32(Console.ReadLine());
if(num2 % num1 == 0)
{
    Console.WriteLine("Кратное");
}
else
{
    Console.WriteLine($"Не Кратное,остаток = {num2 % num1 }" );
}       
} 
void Zadacha_4()
{
// Напишите программу которая принимает на  вход число и проверят кратно ли оно одновременно 7 и 23
Console.WriteLine(" Введите число");
int num = Convert.ToInt16(Console.ReadLine());
if(num % 161 != 0)Console.WriteLine($" Число {num} не кратное одновременно 7 и 23");
else Console.WriteLine($" Число {num}  кратное одновременно 7 и 23" );
}

  void Zadacha_5() 
{
 // Напишите программу которая принимает на вход два числа и проверяет.
 // является ли одно число квадратом другого.
Console.WriteLine( "Введите первое число");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine( "Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());
if(num == num2 * num2 || num2 == num * num)
{
    Console.WriteLine("да");
}
else 
{
    Console.WriteLine("Нет");
}
}
void DomZadacha_0()
{
// Домашнее задание.Напишит программу которая принимает на вход трех 
// значное число и на выходе показывает вторую цифру этого числа
Console.WriteLine(" Введите трехзначное число");
int numb = Convert.ToInt32(Console.ReadLine());
int number = numb % 100 / 10 ;
Console.Write(number);
}
void DomZadacha_1()
{
//Домашняя работа.Напишите программу, которая принимает на вход цифру, обозначающую день недели,
//, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите число от 1 до 7 обозначающий день недели");
int day = Convert.ToInt32(Console.ReadLine());
if( day == 6 || day == 7)
{
    Console.WriteLine(day + " Выходной");
}
else 
{
    Console.WriteLine(day + " Будни");
}
}
//Домашнее задание Напишите программу, которая с помощью деления выводит третью цифру 
//или сообщает, что третьей цифры нет.645->5 78- третьей цифры нет 3267432979 -> 6
Console.WriteLine(" Введите  число");
int number = Convert.ToInt32(Console.ReadLine());
int n = number % 10;// Спомощью деления из 645 нашел число 5
 Console.WriteLine(n);
// Как показать что 3 цифры нет с помощью програмирования я пока не понял Обьясните на уроке пожалуста
// Есть догадки что надо сравнивать переменную с > 2 но как это записать пока не знаю.




