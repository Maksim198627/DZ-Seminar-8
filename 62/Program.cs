// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
            {
                System.Console.Write("0" + array[i, j] + " ");
            }
            else System.Console.Write(array[i, j] + " ");
        }
        System.Console.WriteLine("");
    }
}

int[,] array = new int[4, 4];

int num = 1;
int i = 0;
int j = 0;

while (num <= 4 * 4)
{
    array[i, j] = num;

    if (i <= j + 1 && i + j < 4- 1)
    {
        ++j;
    }
    else if (i < j && i + j >= 4 - 1)
    {
        ++i;
    }
    else if (i >= j && i + j > 4 - 1)
    {
        --j;
    }
    else
    {
        --i;
    }
    ++num;
}

PrintArray(array);
System.Console.Write("Для продолжения нажмите любую кнопку:  ");
Console.ReadKey();