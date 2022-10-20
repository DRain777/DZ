void Zadacha46()
{// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
 //m = 3, n = 4. 1 4 8 19 5 -2 33 -2 77 3 8 1
    Random random = new Random();
    int rows = random.Next(4, 8);
    int columns = random.Next(4, 8);
    Console.WriteLine($" Размер массива  {rows}х{columns}");
    int[,] matrix = new int[rows, columns];
    FillArray(matrix);
    PrintArray(matrix);
}


void FillArray(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    Random random = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = random.Next(-10, 100);

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

void Zadacha48()
{// {Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: A = m+n.
 // Выведите полученный массив на экран.
 // m = 3, n = 4.
 // 0 1 2 3
 // 1 2 3 4
 // 2 3 4 5
    Random random = new Random();
    int rows = random.Next(3, 4);
    int columns = random.Next(3, 4);
    Console.WriteLine($" Размер массива  {rows}х{columns}");
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = i + j;//A = m+n.
        }
    }
    PrintArray(matrix);
}
void Zadacha49()
{// {Задача 49: Задайте двумерный массив. Найдите элементы, у
 // которых оба индекса чётные, и замените эти элементы на их
 // квадраты.
 // Например, изначально массив
 // выглядел вот так:
 //1 4 7 2                              1 4 7 2
 //5 9 2 3                              5 81 2 9 
 //8 4 2 4                              8 4 2 4 
    Random random = new Random();
    int rows = random.Next(4, 8);
    int columns = random.Next(4, 8);
    Console.WriteLine($" Размер массива  {rows}х{columns}");
    int[,] matrix = new int[rows, columns];
    FillArray(matrix);
    PrintArray(matrix);
    for (int i = 0; i < rows; i += 2)
    {
        for (int j = 0; j < columns; j += 2)
        {
            matrix[i, j] = matrix[i, j] * matrix[i, j];
        }

    }
    Console.WriteLine();
    PrintArray(matrix);
}
void Zadacha51()
{// {Задача 51: Задайте двумерный массив. Найдите сумму
 // элементов, находящихся на главной диагонали (с индексами (0,0);
 // (1;1) и т.д.
 // Например, задан массив:
 // 1 4 7 2
 // 5 9 2 3
 // 8 4 2 4
 // Сумма элементов главной диагонали: 1+9+2 = 12
    Random random = new Random();
    int rows = random.Next(4, 8);
    int columns = random.Next(4, 8);
    int sum = 0;
    Console.WriteLine($" Размер массива  {rows}х{columns}");
    int[,] matrix = new int[rows, columns];
    FillArray(matrix);
    PrintArray(matrix);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if (i == j)
            {
                sum = sum + matrix[i, j];
            }
        }
    }
    Console.Write($"Сумма элементов главной диагонали  = {sum}");

}
void FillArrayCustom(int[,] matrix, int minBalls = 0, int maxBalls = 1)
{
    maxBalls++;
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    Random random = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = random.Next(minBalls, maxBalls);

        }
    }

}

void ZadachaProFutboll()
{//Дан двумерный массив из двух(2) строк и (12) столбцов.В его первой строке записанно количество мячей
 // забитой футбольной командой в той или иной игре. во второй количество пропущенных мячей в этой же игре.
 //А)- для каждой проведенной игры напечатать словесный результат(выигыш.ничья.проигрыш)
 //Б)- определить количество выйгрышей  данной команды
 //B)- определить количество выйгрышей и количество пройгрышей данной команды
 //Г)- определить количество выйгрышей.ничьих.проигрышей данной команды
 //Д)- определить в скольких играх разность забитых ипропущенных мячей больше илии равно 3
 //Е)- определить общее число очков набранный командой.выйгрыш-3 очка.ничья-1.поражения-0
 // Random random = new Random();
 // int rows = random.Next(2,12);
 // int columns = random.Next(2,12);
    int rows = 2;
    int columns = 12;
    int[,] matrix = new int[rows, columns];
    Console.WriteLine($" Размер массива  2 x 12");
    FillArrayCustom(matrix, 0, 10);
    PrintArray(matrix);
    int sumvictori = 0;
    int sumlose = 0;
    int sumdraw = 0;

    for (int i = 0; i < columns; i++) // matrix GetLength(0) [3 4]=[0,1]
    {
        if (matrix[0, i] > matrix[1, i])
        {
            sumvictori++;
            Console.WriteLine($"Победа:  счет {matrix[0, i]}   {matrix[1, i]} ");

        }
    }
    for (int i = 0; i < columns; i++) // matrix GetLength(0) [3 4]=[0,1]
    {
        if (matrix[0, i] < matrix[1, i])
        {
            sumlose++;
            Console.WriteLine($"Поражения: счет {matrix[0, i]}   {matrix[1, i]} ");

        }
    }
    for (int i = 0; i < columns; i++) // matrix GetLength(0) [3 4]=[0,1]
    {
        if (matrix[0, i] == matrix[1, i])
        {
            sumdraw++;
            Console.WriteLine($"Ничья:  счет {matrix[0, i]}   {matrix[1, i]} ");

        }
    }
    Console.WriteLine(sumlose + "  " + "Количество Поражений");
    Console.WriteLine(sumvictori + "  " + "Количество Побед");
    Console.WriteLine(sumdraw + " " + "Количество Ничьих");
    Console.WriteLine("Кочичество очков" + " " + (sumvictori * 3 + sumdraw));





}


void Zadacha47Domash()
{//Задача 47: Задайте двумерный массив размером m×n, 
 // заполненный случайными вещественными числами, округлёнными до одного знака.
 //m = 3, n = 4.
 //0,5 7 -2 -0,2
 //1 -3,3 8 -9,9
 //8 7,8 -7,1 9
    double[,] matrix = new double[3, 4];
    Random random = new Random();
    int rows = 3;
    int columns = 4;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = Math.Round(random.NextDouble(), 1);
            //.Write(matrix[i, j]);

        }
    }
    rows = 3;

    columns = 4;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }

}
void Zadach50Domash()
{//Задача 50: Напишите программу, которая на вход принимает индексы элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
 // Например, задан массив:
 // 1 4 7 2
 // 5 9 2 3
 // 8 4 2 4
 // 17 -> такого числа в массиве нет
    Console.WriteLine("Введите индекс строки: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите индекс столбца: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    int[,] matrix = new int[3, 4];
    FillArray(matrix);
    PrintArray(matrix);
    if (rows < matrix.GetLength(0) && columns < matrix.GetLength(1))
    {
        Console.WriteLine(matrix[rows, columns]);
    }
    else
    {
        Console.WriteLine($"{rows}{columns} -> такого числа в массиве нет");
    }

}
void Zadach52Domash()
{//Задача 52: Задайте двумерный массив из целых чисел.
 // Найдите среднее арифметическое элементов в каждом столбце.
 //Например, задан массив:
 //1 4 7 2
 //5 9 2 3
 //8 4 2 4
 //Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
    Console.WriteLine("Введите индекс строки: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите индекс столбца: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Массив = {rows}x{columns} ");
    int[,] matrix = new int[rows, columns];
    FillArray(matrix);
    PrintArray(matrix);
    for (int j = 0; j < matrix.GetLength(1); j++)
{ 
    double avarage = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        avarage = (avarage + matrix[i, j]);
    }
    avarage = avarage / rows;
    Console.Write(avarage + "; " + "\t" );
}
Console.WriteLine();

}
