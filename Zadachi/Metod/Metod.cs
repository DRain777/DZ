void Zadach31()
{
    //Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму
    //отрицательных и положительных элементов массива.Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
    //положительных чисел равна 29, сумма отрицательных равна-20.

    int size = 12;
    int[] numbers = new int[size];
    FillArray(numbers);
    PrintArray(numbers);
    Console.WriteLine(GetsummaPozitiv(numbers));
    Console.WriteLine(GetsummaNigativ(numbers));
}


int GetsummaPozitiv(int[] numbers)
{

    int summa = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > 0)
        {
            summa += numbers[i];                    //summa + numbers[i];
        }

    }
    return summa;
}
int GetsummaNigativ(int[] numbers)
{
    int summa = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] < 0)
        {
            summa += numbers[i];            //summa + numbers[i];
        }

    }
    return summa;
}
void FillArray(int[] numbers)   //int minValue = 0,int maxValue = 100)
{
    Random random = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = random.Next(1, 20);// minValue,maxValue
    }

}
void PrintArray(int[] numbers)
{
    Console.WriteLine(" Ввывод массива");

    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + "  ");
    }
    Console.WriteLine();
}
void Zadach32()
//Задача 32: Напишите программу замены элементов массива: положительные элементы замените на
//соответствующие отрицательные, и наоборот. [-4, -8, 8, 2] -> [4, 8, -8, -2]
{
    int size = 12;
    int[] numbers = new int[size];
    FillArray(numbers);
    PrintArray(numbers);
    ChangeValue(numbers);
    PrintArray(numbers);


    void ChangeValue(int[] numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = numbers[i] * -1;//  numbers[i] *= -1;
        }
    }


}
void WriteMassiv()
{
    Console.WriteLine("Введите число для поиска в массиве");
    int indexNumber = Convert.ToInt32(Console.ReadLine());
}
void Zadach33()
//Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
//4; массив [6, 7, 19, 345, 3] -> нет 3; массив [6, 7, 19, 345, 3] -> да
{
    int size = 12;
    int[] numbers = new int[size];
    Console.WriteLine("Введите число для поиска в массиве");
    int indexNumber = Convert.ToInt32(Console.ReadLine());
    // WriteMassiv();
    FillArray(numbers);
    CheckArray(numbers, indexNumber);
    PrintArray(numbers);
}

void CheckArray(int[] numbers, int indexNumber)
{
    bool flag = false;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (indexNumber == numbers[i])
        {
            flag = true;
        }


    }
    if (flag == true)
        Console.WriteLine($" Число {indexNumber} находится в массиве");
    else
        Console.WriteLine($" Число {indexNumber} НЕ находится в массиве");
}
//Zadach33(); 
void Zadacha35()
{
    //Задача 35: Задайте одномерный массив из 10 случайных чисел.
    //Найдите количество элементов массива, значения которых лежат в
    //отрезке [10,99].
    //[5, 18, 123, 6, 2] -> 1
    //[1, 2, 3, 6, 2] -> 0
    //[10, 11, 12, 13, 14] -> 5

    int size = 10;
    int[] numbers = new int[size];
    FillArray(numbers);
    FindArray(numbers);
    PrintArray(numbers);



}

void FindArray(int[] numbers)
{
    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] >= 10 && numbers[i] <= 99)
        {
            count++;
        }

    }
    Console.WriteLine(count);

}



void Domashka29()
{//Задача 29: Напишите программу, которая задаёт массив из 8 случайных целых чисел 
 //и выводит отсортированный по модулю массив.   -2, 1, 7, 5, 19 -> [1, -2, 5, 7, 19]   6, 1, -33 -> [1, 6, -33]
    int size = 15;
    int[] numbers = new int[size];
    FillArray(numbers);
    PrintArray(numbers);

    for (int i = 0; i < numbers.Length; i++)
    {
        for (int j = 0; j < numbers.Length - i; j++)
        {
            if (Math.Abs(numbers[j]) > Math.Abs(numbers[j + 1])) //  Math.Abs модуль числа
            {
                int temp = numbers[j];
                numbers[j] = numbers[j + 1];
                numbers[j + 1] = temp;

            }
            PrintArray(numbers);                               // Console.Write(numbers[j]);
        }
        // Console.WriteLine();
    }


}
//Domashka29();
void Zadacha34Dom()
{//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
 //Напишите программу, которая покажет количество чётных чисел в массиве. [345, 897, 568, 234] -> 2
    int size = 10;
    int[] numbers = new int[size];
    FillArray(numbers);
    PrintArray(numbers);

    //int sum = 0;
    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] % 2 == 0) count++; // Нажождения четных элементов
        //if (i % 2 == 1) Sum += numbers[i];
    }
    Console.WriteLine(" Количество четных элементов: " + count);
    //Console.WriteLine("Сумма элементов на нечетных позициях " + count);
}
void Zadacha36Dom()
{//Задача 36. Задайте одномерный массив, заполненный случайными числами.
 //  Найдите сумму элементов с нечётными индексами.  [3, 7, 23, 12] -> 19  [-4, -6, 89, 6] -> 0
    int size = 10;
    int[] numbers = new int[size];
    FillArray(numbers);
    PrintArray(numbers);

    int summa = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] % 2 == 1) summa += numbers[i];

    }
    Console.WriteLine($" Сумма элементов с  нечетными индексами  {summa}");
}
void Zadacha38Dom()
{// Задача 38: Задайте массив вещественных чисел. 
 // Найдите разницу между максимальным и минимальным элементов массива.
 //[3,21 7,04 22,93 -2,71 78,24] -> ma
 //[3,21 7,04 22,93 -2,71 78,24] -> max = 78,24, min = - 2,71, difference = 80,95
}


void Zadacha39()
{  // Задача 39: Напишите программу, которая перевернёт
   //одномерный массив (последний элемент будет на первом
   //месте, а первый - на последнем и т.д.)
   //[1 2 3 4 5] -> [5 4 3 2 1]
   //[6 7 3 6] -> [6 3 7 6]
    int size = 10;
    int[] numbers = new int[size];
    FillArray(numbers);
    PrintArray(numbers);
    ReversArray(numbers);
    PrintArray(numbers);
    // int maxIndex = size - 1;
    // for (int i = 0; i < size % 2; i++)
    // {
    //     // (numbers[i], numbers[maxIndex - i]) = (numbers[maxIndex - i], numbers[i]);//Картэж обмен переменных
    //     int temp = numbers[i];
    //     numbers[i] = numbers[maxIndex - i];
    //     numbers[maxIndex - i] = temp;

    // }

}
void ReversArray(int[] numbers)// Переворот массива
{
    int size = numbers.Length;
    int maxIndex = size - 1;
    for (int i = 0; i < size % 2; i++)
    {
        // (numbers[i], numbers[maxIndex - i]) = (numbers[maxIndex - i], numbers[i]);//Картэж обмен переменных
        int temp = numbers[i];
        numbers[i] = numbers[maxIndex - i];
        numbers[maxIndex - i] = temp;

    }



}
void Zadacha40()
{//Задача 40: Напишите программу, которая принимает на вход три
 //числа и проверяет, может ли существовать треугольник со
 //сторонами такой длины.
 //Теорема о неравенстве треугольника: каждая сторона треугольника
 //меньше суммы двух других сторон.
    int sidea = 5;
    int sideb = 4;
    int sidec = 3;

    if (sidea + sideb > sidec && sidea + sidec > sideb && sideb + sidec > sidea)
    {
        Console.WriteLine("Треугольник существует");
    }
    else
    {
        Console.WriteLine("Треугольник НЕ существует");
    }
}
void Zadacha42()
{//Задача 42: Напишите программу, которая будет преобразовывать
 //десятичное число в двоичное.
 //45 -> 101101
 //3 -> 11
 //2 -> 10
    int number = 43;
    string result = "";
    while (number > 0)
    {
        result = number % 2 + result;// result += number%2
        number /= 2;
        Console.WriteLine(result);
    }
}
void Zadacha42Convert()// Конвертация с Дяситичной системы в Двоичную.
{
    int number = 51;
    string result = Convert.ToString(number, 2);
    Console.WriteLine(result);
}
void Zadacha44()
{
    //Задача 44: Не используя рекурсию, выведите первые N чисел
    //Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
    //Если N = 5 -> 0 1 1 2 3
    //Если N = 3 -> 0 1 1
    //Если N = 7 -> 0 1 1 2 3 5 8
    Console.WriteLine(" Введите число N Фибоначи");
    int size = Convert.ToInt32(Console.ReadLine());
    int a = 0;
    int b = 1;
    int[] numbers = new int[size];
    numbers[0] = a;
    numbers[1] = b;
    for (int i = 2; i < numbers.Length; i++)
    {
        numbers[i] = numbers[i - 2] + numbers[i - 1];
    }
    PrintArray(numbers);
}
void Zadacha45()
{//Задача 45: Напишите программу, которая будет создавать
 //копию заданного массива с помощью поэлементного копирования.
    int size = 10;
    int[] numbers = new int[size];
    int[] other = new int[size];
    FillArray(numbers);
    PrintArray(numbers);
    for (int i = 0; i < numbers.Length; i++)
    {
        other[i] = numbers[i];
    }
    PrintArray(other);
}

void Test(int test = 0)     //Recursia
{
    if (test == 100) return;// Выход из Рекурсии
    test++;
    Console.WriteLine(test);

    Test(test);// ++test
}
// Найти сумму цифр числа через Рекурсию
void Recursia(int test = 0, int sum = 0)
{
    if (test == 0)
    {
        Console.WriteLine(sum); ;
        return;
    }
    sum += test % 10;
    test /= 10;
    Recursia(test, sum);
}
void Zadacha41Domash()
{//Задача 41: Пользователь вводит с клавиатуры M чисел. 
 // Посчитайте, сколько чисел больше 0 ввёл пользователь.
 //0, 7, 8, -2, -2 -> 2   1, -7, 567, 89, 223-> 3
    Console.WriteLine(" Введите Число M ");
    int numbers = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(" Введите Число M ");
    int numbers1 = Convert.ToInt32(Console.ReadLine());
    if (numbers > 0)
    {
        Console.WriteLine($" {numbers} Больше 0 ");
    }
    else
    {
        Console.WriteLine($" {numbers} Меньше 0 ");
    }
    if (numbers1 > 0)
    {
        Console.WriteLine($" {numbers1} Больше 0 ");
    }
    else
    {
        Console.WriteLine($" {numbers1} Меньше 0 ");
    }

}
void Zadacha41DomashD()
{//Задача 41: Пользователь вводит с клавиатуры M чисел. 
 // Посчитайте, сколько чисел больше 0 ввёл пользователь.
 //0, 7, 8, -2, -2 -> 2   1, -7, 567, 89, 223-> 3
    Console.WriteLine(" Сколько чисел требуется ввести? ");
    int countofnumbers = Convert.ToInt32(Console.ReadLine());
    int count = 0;// // int[] numbers = new int[ountofnumbers];
    for (int i = 1; i <= countofnumbers; i++)
    {
        Console.WriteLine($" Введите {i} число ");
        int inputnumber = Convert.ToInt32(Console.ReadLine());
        if (inputnumber > 0) count++; //numbers[i-1] = inputnumber
                                      // if(inputnumber > 0) count++

    }
    Console.WriteLine($"Положительных чисел введено  {count}");
}
void Zadacha43Domash()
{//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
 //заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
 //b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
    var (k1, b1) = (2, 5);//vereibal переменная  представляет не явную типизацию(int)
    var (k2, b2) = (4, 9);
    double x = (b2 - b1) / (k1 - k2);
    x = Math.Round(x, 2);
    double y = k1 * x + b1;
    y = Math.Round(y, 2);
    Console.WriteLine($"Точка пересечения А({x},{y})");
}
Zadacha43Domash();