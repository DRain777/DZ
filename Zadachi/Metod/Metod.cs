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
        numbers[i] = random.Next(9, 20);// minValue,maxValue
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









