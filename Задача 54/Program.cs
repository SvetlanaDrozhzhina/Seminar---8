// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Console.WriteLine($"Введите размер массива и диапазон случайных значений: ");
int a = InputNumbers("Введите a: ");
int b = InputNumbers("Введите b: ");
int range = InputNumbers("Введите диапазон: от 1 до ");
int[,] array = new int[a, b];
CreateArray(array);
WriteArray(array);
Console.WriteLine($"Отсортированный массив: ");
OrderArrayLines(array);
WriteArray(array);
void OrderArrayLines(int[,] array)
{
    for (int c = 0; c < array.GetLength(0); c++)
    {
        for (int d = 0; d < array.GetLength(1); d++)
        {
            for (int i = 0; i < array.GetLength(1) - 1; i++)
            {
                if (array[c, i] < array[c, i + 1])
                {
                    int temp = array[c, i + 1];
                    array[c, i + 1] = array[c, i];
                    array[c, i] = temp;
                }
            }
        }
    }
}
int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}
void CreateArray(int[,] array)
{
    for (int c = 0; c < array.GetLength(0); c++)
    {
        for (int d = 0; d < array.GetLength(1); d++)
        {
            array[c, d] = new Random().Next(range);
        }
    }
}
void WriteArray(int[,] array)
{
    for (int c = 0; c < array.GetLength(0); c++)
    {
        for (int d = 0; d < array.GetLength(1); d++)
        {
            Console.Write(array[c, d] + " ");
        }
        Console.WriteLine();
    }
}