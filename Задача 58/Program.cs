// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Console.WriteLine($"\nВведите размеры матриц и диапазон случайных значений:");
int m = InputNumbers("Введите число строк 1-й матрицы: ");
int n = InputNumbers("Введите число столбцов 1-й матрицы и строк 2-й матрицы: ");
int p = InputNumbers("Введите число столбцов 2-й матрицы: ");
int range = InputNumbers("Введите диапазон случайных чисел: от 1 до ");
int[,] firstMartrix = new int[m, n];
CreateArray(firstMartrix);
Console.WriteLine($"\nПервая матрица: ");
WriteArray(firstMartrix);
int[,] secomdMartrix = new int[n, p];
CreateArray(secomdMartrix);
Console.WriteLine($"\nВторая матрица:");
WriteArray(secomdMartrix);
int[,] resultMatrix = new int[m,p];
MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
Console.WriteLine($"\nПроизведение первой и второй матриц:");
WriteArray(resultMatrix);
void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
    for (int a = 0; a < resultMatrix.GetLength(0); a++)
    {
        for (int b = 0; b < resultMatrix.GetLength(1); b++)
        {
            int sum = 0;
            for (int c = 0; c < firstMartrix.GetLength(1); c++)
            {
                sum += firstMartrix[a,c] * secomdMartrix[c,b];
            }
            resultMatrix[a,b] = sum;
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
    for (int a = 0; a < array.GetLength(0); a++)
    {
        for (int b = 0; b < array.GetLength(1); b++)
        {
            array[a, b] = new Random().Next(range);
        }
    }
}
void WriteArray (int[,] array)
{
    for (int a = 0; a < array.GetLength(0); a++)
    {
        for (int b = 0; b < array.GetLength(1); b++)
        {
            Console.Write(array[a,b] + " ");
        }
        Console.WriteLine();
    }
}