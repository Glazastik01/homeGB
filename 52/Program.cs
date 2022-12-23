int GetNumber(string message)
{
    int result = 0;

    while(true)
    {
    Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result))
        {
        break;
        }
        else
        {
        Console.WriteLine("Ввели не число");
        }
    }
    return result;
}

double[,] InitMatrix(int rows, int columns)
{
    double[,] matrix = new double[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {   
            matrix[i,j] = rnd.Next(1, 10);
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


int rows = GetNumber("Введите количество строк:");
int columns = GetNumber("Введите количество столбцов:");

double[,] matrix = InitMatrix(rows, columns);
PrintMatrix(matrix);

double sr = 0;
for(int j = 0; j < columns; j++){
    double sum = 0;
    for(int i = 0; i < rows; i++){
        sum += matrix[i, j];
    }
    sr = sum / rows;
    Console.WriteLine("Среднее арифметическое {0} столбца равно: {1}", j, sr);
}
