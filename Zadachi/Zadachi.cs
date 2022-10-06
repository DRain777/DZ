
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
if(numb > 99 && numb < 999)
{
   Console.WriteLine(" Вторая цифра" +" " + numb % 100 / 10); // /10%/10
}
else
{
    Console.WriteLine(" ЧИСЛО НЕ 3Х ЗНАЧНОЕ");
}   
}
void DomZadacha_1()
{
// Домашняя работа.Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// , и проверяет, является ли этот день выходным.
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
void DomZadacha_2()
{
// Домашнее задание Напишите программу, которая с помощью деления выводит третью цифру 
// или сообщает, что третьей цифры нет.645->5 78- третьей цифры нет 3267432979 -> 6
Console.WriteLine(" Введите  число");
int number = Convert.ToInt32(Console.ReadLine());
number = Math.Abs(number);
if(number > 99)
{
    while(number >999)
{
    number /= 10; 
}    
 Console.WriteLine(" Третья Цифра" + "  " + number % 10 );
}
else
{
    Console.WriteLine( " Третьей цифры нет");
}    
}
// DateTime lastTime = DateTime.Now;
// int number = 123;
// for(int i = 0; i > 1000000000; i++)
// {
//     var n = number/10% 10;    // Convert.ToString(number)[1];
// } 
// Console.WriteLine(DateTime.Now - lastTime);
//void Zadach_massiv()
// Домашнее задание.Напишит программу которая принимает на вход трех 
// значное число и на выходе показывает вторую цифру этого числа
// Console.WriteLine("Введите число от 1 до 7 обозначающий день недели");
// int day = Convert.ToInt32(Console.ReadLine());
// string[] week = {"пн","вт","ср","чт","пт","сб","вс"};
// if(day > 0 && day < 8)
// {
//    Console.WriteLine(week[day-1]);
// if (day == 6 || day == 7)
// {
//     Console.WriteLine("Выходной");
// }
// else
// {
//     Console.WriteLine(" Будни");
// }
// }
void Zadacha17()
{
    // напишите программу,которая принимает на вход координаты точки (x и y),причем x не равно 0 и Y не равно 0 и выдает номер
    // четверти плоскости.в которой находится
    Random random = new Random();
    int x = random.Next(-10,11);
    int y = random.Next(-10,11);
    Console.WriteLine($"a{x}, {y})");
    if( x > 0 && y > 0)
{
    Console.WriteLine("Точка лежит в первой четверти");
}
else if ( x > 0 && y > 0)
{
    Console.WriteLine("Точка лежит во второй четверти");
}
else if( x < 0 && y > 0)
{
     Console.WriteLine("Точка лежит в первой четверти");
}
else if( x > 0 && y < 0)
{
     Console.WriteLine("Точка лежит в первой четверти");
}
else
{
    Console.WriteLine("Точка лежит на одной из осей");
}    
}
void Zadacha18()
{
//Задача 18: Напишите программу, которая по
//заданному номеру четверти, показывает диапазон
//возможных координат точек в этой четверти (x и y)
Console.WriteLine("Введите номер четверти ");
int numb = Convert.ToInt32(Console.ReadLine());
if(numb == 1)
{
    Console.WriteLine( " Введенная четверть > o и y > o");
}
else if(numb == 2)
{
    Console.WriteLine("Введенная четверть x < 0 и Y > 0"); 
}
else if(numb == 3)
{
    Console.WriteLine("Введенная четвертьx x < 0 и y < 0" );
}
else if (numb == 4)
{
    Console.WriteLine(" Введенная четверть x > 0 и Y < 0");
}
else
{
    Console.WriteLine("Вы вели не коректную четверть");
}
}
 void Zadacha21()
 {
//Задача 21: Напишите программу, которая принимает на вход координаты двух точек и
//находит расстояние между ними в 2Dпространстве.
//A (3,6); B (2,1) -> 5,09
//A (7,-5); B (1,-1) -> 7,21
Random random = new Random();
int ax = random.Next(-10,11);
int ay = random.Next(-10,11);
int bx = random.Next(-10,11);
int by = random.Next(-10,11);

Console.WriteLine($"Точки: А {ax},{ay},B {bx},{by}");
Console.WriteLine($" Растояния между точками А и Б:{Math.Sqrt(Math.Pow((bx - ax),2) + Math.Pow((by - ay),2))}" );
 }
 void Zadacha22()
 {
//Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу
//квадратов чисел от 1 до N
int number = 17;
int counter = 1;
while(counter <= number)
{
    Console.WriteLine($"{counter} * {counter} = {counter * counter} ");
    counter++;
}
 }
 void Zadacha19_domashka()
 {
// Задача 19 Напишите программу, которая принимает на вход пятизначное
//  число и проверяет, является ли оно палиндромом.
int number = 18381;
int result = 0;
int current_number = number;
if(number < 9999 | number > 99999)
{
    Console.WriteLine($"число {number} не пяти значное ");
}
while (current_number > 0)
{ 
    int digit = current_number  % 10;
    result = result * 10 + digit; 
    current_number /= 10;
    Console.WriteLine(result);
}
if(number == result)
{
    Console.WriteLine($"{number} Палиндром");
}
else
{
    Console.WriteLine($"{number} не палиндром");
}
}
void Zadacha19_domashka_0()
{
//Задача 19 Напишите программу, которая принимает на вход пятизначное
//  число и проверяет, является ли оно палиндромом.
Console.WriteLine(" Введите 5-ти значное число");
int number = Convert.ToInt32(Console.ReadLine());
string numbstring = Convert.ToString(number); 
if(number < 9999 | number > 99999)
{
    Console.WriteLine($"число {number} не 5-ти значное ");
}
else
{
    if(numbstring[4] == numbstring[0] && numbstring[3] == numbstring[1] )
    {
        Console.WriteLine($"{number} является Палиндромом");
    }
    else
    {
        Console.WriteLine($"{number} НЕ является Палиндромом");   
    }
}
}   
void DomZadacha_21()
{
//Задача 21 Напишите программу, которая принимает на вход координаты 
//двух точек и находит расстояние между ними в 3D пространстве.
        //A (3,6,8); B (2,1,-7), -> 15.84
        //A (7,-5, 0); B (1,-1,9) -> 11.53
int a_x = 7;
int a_y = 7;
int a_z = 7;
int b_x = 0;
int b_y = 0;
int b_z = 0; 
double result = Math.Sqrt(Math.Pow(a_x - b_x,2) + Math.Pow(a_y - b_y,2) + Math.Pow(a_z - b_z,2));
Console.Write($"{result} Растояния");
}
 void Zadacha_Dom23()
 {
// Задача 23 Напишите программу, которая принимает на вход 
// число (N) и выдаёт таблицу кубов чисел от 1 до N.                    
//  3 -> 1, 8, 27   5 -> 1, 8, 27, 64, 125
Console.WriteLine("Введите число N ");
int n = Convert.ToInt16(Console.ReadLine());
int count = 1;
while (count <= n)
{
    Console.WriteLine($"{count} * {count} * {count} = { count * count * count}");
    count++;
}
}
 void Zadacha_Dom23for()
 {
// Задача 23 Напишите программу, которая принимает на вход 
// число (N) и выдаёт таблицу кубов чисел от 1 до N.  Через for                   
//  3 -> 1, 8, 27   5 -> 1, 8, 27, 64, 125
Console.WriteLine("Введите число N ");
int n = Convert.ToInt16(Console.ReadLine());
for(int i = 1; i <= n; i++)
{
    Console.WriteLine($"{i} * {i} * {i} = {Math.Pow(i, 3)}");
}
}
void Zadacha24()
{
//Задача 24: Напишите программу, которая
//принимает на вход число (А) и выдаёт сумму чиселот 1 до А.
Console.WriteLine("Введите число N ");
int n = Convert.ToInt16(Console.ReadLine());
int summa = 0;
for(int i = 1; i <= n; i++)
{
    //Console.Write($"{i} + ");
    summa += i;
}
Console.Write($"{summa}");
}
 void Zadacha26()
 {
// Задача 26: Напишите программу, которая принимает
//на вход число и выдаёт количество цифр в числе.
Console.WriteLine("Введите число  ");
int n = Convert.ToInt16(Console.ReadLine());
int current = n;
int count = 0;
while(current > 0)
{
    current = current / 10;
    count = count + 1;
}
    Console.WriteLine($" Количество цифр в числе {n} = {count}");
}
void Zadacha26_()
{
int number = 555;
int i = 0;
while( number > 0)// сколько раз пройдет цил такое и будет значение i соответсвенно столько и цифр в числе.
{
    number /= 10;
    i++;
    Console.WriteLine($" {number} {i}" );
}
 Console.WriteLine(i);
}
void Zadacha26_string()
{
 int num  =557777;
 string num2 = Convert.ToString(num);
 Console.WriteLine(num2.Length);// команда Length вывовит количестыо цифр в числе чрез строку.
}
void Zadach28()
{
//  задача 28 напишите программу которая на входе число N и выдает 
// произведени чисел от 1 до N
Console.WriteLine("Введите число N ");
int n = Convert.ToInt16(Console.ReadLine());
int resultat = 1;
for(int i = 1; i <= n ; i++)
{
    resultat = resultat * i;
    Console.WriteLine(resultat);
}
}
void Zadacha30()
{
//Задача 30: Напишите программу, которая
//выводит массив из 8 элементов, заполненный
//нулями и единицами в случайном порядке.[1,0,1,1,0,1,0,0]
Random random = new Random();
int size = random.Next(4, 10);
int[] numbers = new int [size];
Console.WriteLine(size);

 FillArray(numbers );

//for(int i = 1; i < size; i++)
//{
   // numbers[i] = random.Next(0 ,2);
   // Console.Write(numbers[i] + "  ");// /t табуляция
//}

for(int i = 1; i < size; i++)
{
  Console.Write(numbers[i] + "  ");   
}
    Console.WriteLine();
}
void FillArray(int[] num )
{
    Random random = new Random();
    for(int i = 1; i < num.Length; i++) // Length запрашивает длинну массива . вместо size
{
    num[i] = random.Next(0 ,2);
    //Console.Write(num[i] + "  ");// /t табуляция
}
}
//Zadacha30();
void Zadacha_25Domashka()
{
// Задача 25: Используя определение степени числа,
//напишите цикл, который принимает на вход два
//натуральных числа (A и B) и возводит число A в степень B
Console.WriteLine("Введите число A ");
int a = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Введите число B ");
int b = Convert.ToInt16(Console.ReadLine());
int proiz = 1;
for(int i = 1; i <= b; i++)
{
    proiz = proiz * a;  // proiz *= a
   // Console.WriteLine(proiz);
}
 Console.WriteLine($"Число{a} в степени {b} = {proiz}  ");
}
void Zadacha27_Domash()
{
    //Задача 27: Напишите программу, которая принимает на
//вход число и выдаёт сумму цифр в числе.
Console.WriteLine("Введите число  ");
int number = Convert.ToInt16(Console.ReadLine());
int summa = 0;
while( number > 0)// Пока число больше 0 
{
    summa = summa + number%10;//summa += number%10) К Сумме прибовляем последнюю цифру в веденного числа
    // Что бы получить последнюю чифру надо число поделить на %10(остаток от деления)
    number /= 10; //число уменьшаем 
    //Console.WriteLine(summa);
   // Console.WriteLine(number);
}
Console.Write("Сумма цифр в числе" + "  " + summa);
}
//void Zadacha29_Domash()
//Задача 29: Напишите программу, которая задаёт массив
//из 8 случайных целых чисел и выводит отсортированный по модулю массив.алгоритм сортировки
// Денис Батькович не смог решить эту задачу Сложно пока для меня,


