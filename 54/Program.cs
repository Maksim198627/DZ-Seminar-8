// 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
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

void MaxToMinArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1]) 
                {
                    int box = 0;
                    box = array[i, k];
                    array[i, k] = array[i, k + 1];
                    array[i, k + 1] = box;
                }
            }
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}


System.Console.WriteLine("Данный массив в порядке убывания по-строчно : ");
MaxToMinArray(array);
PrintArray(array);
System.Console.Write("Для продолжения нажмите любую кнопку:  ");
Console.ReadKey();


