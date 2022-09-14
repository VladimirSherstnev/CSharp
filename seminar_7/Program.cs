Console.WriteLine("Задача 47:");

Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Clear();
Console.WriteLine($"m = {m}, n = {n}.");

double[,] array = new double[m, n];
 
for (int i = 0; i < array.GetLength(0); i++) 
{
    for (int j = 0; j < array.GetLength(1); j++)
        array [i, j] = new Random().NextDouble() * 20 - 10;  
}

for (int i = 0; i < m; i++)
  {
      for (int j = 0; j < n; j++)
      {
        double numb = Math.Round(array[i, j], 1);
        Console.Write(numb + "\t  ");
      }
      Console.WriteLine();
  }

Console.WriteLine("Задача 50:");

Console.WriteLine("введите номер строки");
int beta = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите номер столбца");
int alfa = Convert.ToInt32(Console.ReadLine());
int [,] numbers = new int [5,5];
foundnum(numbers);

if (alfa > numbers.GetLength(0) || beta > numbers.GetLength(1))
{
    Console.WriteLine("такого элемента нет");
}
else
{
    Console.WriteLine($"значение элемента {alfa} строки и {beta} столбца равно {numbers[alfa-1,beta-1]}");
}

showarr(numbers);

void foundnum(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {        
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array [i,j] = new Random().Next(-50, 50);
            }   
        }
}

void showarr(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "\t  ");
        }   
        Console.WriteLine(""); 
    }
}

Console.WriteLine("Задача 52:");

Console.WriteLine("введите количество строк");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int m2 = Convert.ToInt32(Console.ReadLine());

int[,] numbers2 = new int[n2, m2];
FillArrayRandomNumbers(numbers2);


for (int j = 0; j < numbers2.GetLength(1); j++)
{
    double avarage = 0;
    for (int i = 0; i < numbers2.GetLength(0); i++)
    {
        avarage = (avarage + numbers2[i, j]);
    }
    avarage = avarage / n2;
    Console.Write(avarage + "; ");
}
Console.WriteLine();
PrintArray(numbers2);



void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t  ");
        }
        Console.WriteLine("");
    }
}