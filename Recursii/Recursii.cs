
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
             steps = rows * ((turn+1)%2) + columns * (turn%2)-1 -turn / 2;

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
Zadach58_Domash();