// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


System.Console.WriteLine("Задан массив: ");
int[,] array = new int[3, 4]
{

    {1,2 ,3, 4},
    {5,6,7,8},
    {9,10,11,12}

    };

for (int y = 0; y < array.GetLength(0); y++)
{
    for (int x = 0; x < array.GetLength(1); x++)

        System.Console.Write(array[y, x] + " ");
    System.Console.WriteLine();
}

void SumElementsArray (int[,] array)
{
    int indexLine = 0;
    int minsum = Int32.MaxValue;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];        
        }
        if (sum < minsum)
        {
            minsum = sum;
            indexLine++;
        }
    }
    Console.WriteLine($"Cтрока с наименьшей суммой елементов под номером: {indexLine}"); 
    Console.WriteLine($"Сумма элементов строки: {minsum}");
}


Console.WriteLine();
SumElementsArray(array);
System.Console.Write("Для продолжения нажмите любую кнопку:  ");
Console.ReadKey();
