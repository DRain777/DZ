
void FillArray(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    Random random = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = random.Next(-9, 10);

        }
    }

}
void PrintArray(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
void Zadacha54_Domash()
{//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
 //по убыванию элементы каждой строки двумерного массива.
 // Например, задан массив:
 // 1 4 7 2
 // 5 9 2 3
 // 8 4 2 4
 // В итоге получается вот такой массив:
 // 7 4 2 1
 // 9 5 3 2
 // 8 4 4 2
    Random random = new Random();
    int rows = random.Next(5, 7);
    int columns = random.Next(5, 7);
    Console.WriteLine($" Размер массива  {rows}х{columns}");
    int[,] matrix = new int[rows, columns];
    FillArray(matrix);
    PrintArray(matrix);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            int edge = columns - j - 1;
            for (int k = 0; k < edge; k++)
            {
                if (matrix[i, k] < matrix[i, k + 1])
                {
                    (matrix[i, k], matrix[i, k + 1]) =
                    (matrix[i, k + 1], matrix[i, k]);

                }

            }
        }
    }
    Console.WriteLine();
    PrintArray(matrix);

}
//Zadacha54_Domash();
void Zadach56_Domash()
{//Задача 56: Задайте прямоугольный двумерный массив.
 // Напишите программу, которая будет находить строку с наименьшей суммой элементов.
 //Например, задан массив:
 //1 4 7 2
 //5 9 2 3
 //8 4 2 4
 //5 2 6 7
 //Программа считает сумму элементов в каждой строке 
 //и выдаёт номер строки с наименьшей суммой элементов: 1 строка
    Random random = new Random();
    int rows = random.Next(4, 5);
    int columns = random.Next(4, 5);
    Console.WriteLine($" Размер массива  {rows}х{columns}");
    int[,] matrix = new int[rows, columns];
    FillArray(matrix);
    PrintArray(matrix);
    int sumMin = 0;
    int index_Min = 0;

    for (int j = 0; j < columns; j++)
    {
        sumMin += matrix[0, j];
        // Console.WriteLine(sumMin);
    }
    Console.WriteLine($" Сумма {index_Min + 1} минемальная строка {sumMin}");
    for (int i = 1; i < rows; i++)
    {
        int sum = 0;
        for (int j = 0; j < columns; j++)
        {
            sum += matrix[1, j];
        }
        Console.WriteLine($"Сумма{i + 1} строки ровна {sum}");
        if (sum < sumMin)
        {
            sumMin = sum;
            index_Min = i;
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Минемальная сумма{sumMin} находится в строке  {index_Min + 1}");
}
void Zadach58_Domash()
{//Задача 58: Напишите программу, которая заполнит спирально массив 4 на 4.
 // Например, на выходе получается вот такой массив:
 // 01 02 03 04
 // 12 13 14 05
 // 11 16 15 06
 // 10 09 08 07

    int rows = 7;
    int columns = 7;
    Console.WriteLine($" Размер массива  {rows}х{columns}");
    int[,] matrix = new int[rows, columns];
    int index = 0;
    int currentRow = 0;
    int currentColumn = 0;// Текущий current

    int changeIndexRow = 0;
    int changeIndexColumn = 1;
    int steps = columns;
    int turn = 0;



    while (index < matrix.Length)
    {
        matrix[currentRow, currentColumn] = index + 1;
        // Console.Write(matrix[currentRow, currentColumn] + " ");
        index++;
        steps--;
        if (steps == 0)
        {
            // if (turn % 2 == 0)
            //     steps = rows - 1 - turn / 2;
            // else
            // steps = columns - 1- turn / 2;
            steps = rows * ((turn + 1) % 2) + columns * (turn % 2) - 1 - turn / 2;

            // steps = columns - 1- turn/2;// работает только для квадратных массивов
            int temp = changeIndexRow;
            changeIndexRow = changeIndexColumn;
            changeIndexColumn = -temp;
            turn++;
        }

        currentRow += changeIndexRow;
        currentColumn += changeIndexColumn;
    }
    PrintArray(matrix);

}

void Zadach63()
{//Задача 63: Задайте значение N. Напишите программу, которая выведет
 // все натуральные числа в промежутке от 1 до N.
 // N = 5 -> "1, 2, 3, 4, 5"
 // N = 6 -> "1, 2, 3, 4, 5, 6"
    Console.WriteLine(" Введите значения N");
    int n = Convert.ToInt32(Console.ReadLine());
    int counter = 0;
    Reccursia(n);
    //FindNatural();
    //int numbers = 0;
    // for (int i = 0; i < n; i++)
    // {
    //     numbers++;
    //     Console.Write($" {numbers} ");

    // }
    // Рекурсия
    //     void FindNatural( int n)
    //     {
    //         a++;

    //          Console.Write(a);
    //          Console.Write(" ");
    //         if (a >= n)
    //         {
    //             return;
    //         }
    //         FindNatural();
    // }
    void Reccursia(int n, int counter = 0)
    {
        counter++;
        Console.Write(counter);
        if (counter >= n)
            return;
        Reccursia(n, counter);




    }
}
void Zadacha65()
{//Задача 65: Задайте значения M и N. Напишите программу, которая
 // выведет все натуральные числа в промежутке от M до N.
 // M = 1; N = 5 -> "1, 2, 3, 4, 5"
 // M = 4; N = 8 -> "4, 6, 7, 8" 
    Console.WriteLine(" Введите значения M");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(" Введите значения N");
    int n = Convert.ToInt32(Console.ReadLine());
    int counter = m - 1;
    Reccursia(m, n, counter);
    void Reccursia(int m, int n, int counter)
    {

        counter++;
        Console.Write(" ");
        Console.Write(counter);
        if (counter >= n)
            return;
        Reccursia(m, n, counter);


    }

}
void Zadacha67()
{//Задача 67: Напишите программу, которая будет принимать на вход число и
 // возвращать сумму его цифр.
 // 453 -> 12
 // 45 -> 9
    Console.WriteLine("Введите число  ");
    int number = Convert.ToInt16(Console.ReadLine());
    int sum = 0;

    Console.WriteLine(SumNuber(number));
}


int SumNuber(int number, int sum = 0)
{
    if (number == 0)
    {
        return sum;
    }
    sum = sum + number % 10;
    number = number / 10;
    return SumNuber(number, sum);

}
void Zadach69()
{//Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
 //возводит число А в целую степень B с помощью рекурсии.
 //A = 3; B = 5 -> 243 (3⁵)
 //A = 2; B = 3 -> 8 
    int a = 5;
    int b = 4;
    int result = 1;
    Pow(a, b, result);
    // for (int i = 0; i < b; i++)
    // {
    //     result = result * a;
    // }
    // Console.WriteLine($"{a}^{b} ={result}");

}
void Pow(int a, int b, int result = 1)
{
    if (b == 0)  //(i >= b)
    {
        Console.WriteLine($"{a}^{b} ={result}");
        return;
    }
    result = result * a;
    b--;        //i++
    Pow(a, b, result); // i
}
void Zadach64Domash()
{//Задача 64: Задайте значения M и N. Напишите рекурсивный метод, 
 //который выведет все натуральные числа кратные 3-ём в промежутке от M до N.
 //N = 5 -> "5, 4, 3, 2, 1"
 //N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

    Console.WriteLine(" Введите значения N");
    int n = Convert.ToInt32(Console.ReadLine());
    int count = 0;
    for (int i = 0; i < n; i++)
    {
        count++;
        if (count % 3 == 0)
        {
            Console.WriteLine(count);
        }
    }




}
void Zadach64Domashv2()
{//Задача 64: Задайте значения M и N. Напишите рекурсивный метод, 
 //который выведет все натуральные числа кратные 3-ём в промежутке от M до N.
 //N = 5 -> "5, 4, 3, 2, 1"
 //N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
    Console.WriteLine(" Введите значения N");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(" Введите значения N");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    int counter = m;
    Reccursia(n, counter);

    void Reccursia(int n, int counter)
    {


        counter++;
        if (counter >= n)
        {
            return;
        }
        if (counter % 3 == 0)
        {
            Console.WriteLine(counter);

        }

        Reccursia(n, counter);

    }
}
void Zadach66Domashv2()
{//Задача 66: Задайте значения M и N. Напишите программу,
 // которая найдёт сумму натуральных элементов в промежутке от M до N.
 //M = 1; N = 15 -> 120
 //M = 4; N = 8. -> 30
 Console.WriteLine(" Введите значения N");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(" Введите значения N");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    int sum = 0;
    GapNumberSum(m, n, sum);
    void GapNumberSum (int m, int n, int sum)
{
    if (m > n) 
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
        return;
    }
    sum = sum + (m++);
    GapNumberSum(m, n, sum);
}
}
void Zadach68Domash()
{
// {Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
//  Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
AkkermanFunction(m,n);
void AkkermanFunction(int m, int n)
{
    Console.Write(Akkerman(m, n)); 
}
int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return (Akkerman(m - 1, Akkerman(m, n - 1)));
    }
}

}
Zadach68Domash();









