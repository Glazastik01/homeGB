
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

int[,] InitMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {   
            matrix[i,j] = rnd.Next(1, 100);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
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


Console.WriteLine("Ведите число, которое надо найти");
int b = Convert.ToInt32(Console.ReadLine());
int rows = GetNumber("Введите количество строк:");
int columns = GetNumber("Введите количество столбцов:");

bool p(int b, int[,] matrix){
    bool t = false;
    for (int i = 0; i < rows; i++){
        for (int j = 0; j < columns; j++){
            if (matrix[i, j] == b){
                t = true;
            } else {
                t = false;
            }
        }
    }
    return t;
}

int[,] matrix = InitMatrix(rows, columns);
PrintMatrix(matrix);
bool f = p(b, matrix);

if (f == true){
    Console.WriteLine($"Число {b} есть в матрице");
} else {
    Console.WriteLine($"Числа {b} нет в матрице");
}