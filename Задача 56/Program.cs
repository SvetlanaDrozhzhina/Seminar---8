// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Console.WriteLine("Введите размерность m массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размерность n массива:  ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] randomArray = new int[m,n];
void mas(int m, int n)
{
int a,b;
Random rand = new Random();
for (a = 0; a < m; a++)
{
    for (b = 0; b < n; b++)
    {
        randomArray[a,b] = rand.Next(1,9);
    }
}
}
void printm(int[,] array)
{
int a,b;
for (a = 0; a < array.GetLength(0); a++)
{
Console.WriteLine();
for (b = 0; b < array.GetLength(1); b++)
{
    Console.Write($"{array[a,b]} ");
}
Console.WriteLine();
}
}
mas(m,n);
Console.WriteLine("\nИсходный массив: ");
printm(randomArray);
int SumLine(int[,] array, int a)
{
int sum = array[a,0];
for (int b = 1; b < array.GetLength(1); b++)
{
    sum += array[a,b];
}
return sum;
}
int minSum = 1;
int sum = SumLine(randomArray, 0);
for (int a = 1; a < randomArray.GetLength(0); a++)
{
    if (sum > SumLine(randomArray, a))
    {
     sum = SumLine(randomArray, a);
     minSum = a+1;
    }
}
Console.WriteLine($"\nСтрока c наименьшей суммой элементов: {minSum}");