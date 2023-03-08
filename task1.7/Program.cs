Console.WriteLine("Задайте количество строк двумерного массива:");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов двумерного массива:");
int cols = Convert.ToInt32(Console.ReadLine());
double[,] array = new double [rows, cols];
Random rnd = new Random();

void PrintArray(double[,] array)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        { Console.Write($"{array[i, j]} \t"); }
        Console.WriteLine();
    }
}

void FillArray(double[,] array)

{ for (int i = 0; i < rows; i++)
 { for (int j = 0; j < cols; j++)
  array[i,j] = Convert.ToDouble(rnd.Next(-100, 100)/10.0);
 }
}
   
FillArray(array);
Console.WriteLine();
PrintArray(array);