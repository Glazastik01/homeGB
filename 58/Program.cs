
int GetNumber(string message){
    int result = 0;
    while(true){
        Console.WriteLine(message);
        if(int.TryParse(Console.ReadLine(), out result)){
            break;
        } Console.WriteLine("Ввели не число");
    }
    return result;
}


int rows = GetNumber("Введите количество строк первой матрицы:");
int columns = GetNumber("Введите количество столбцов первой матрицы:");
int rows2 = GetNumber("Введите количество строк второй матрицы:");
int columns2 = GetNumber("Введите количество столбцов второй матрицы:");


int[,] InitMatrix(int rows, int columns){
    int[,] matrix = new int[rows, columns];
    Random rn = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++){
            matrix[i, j] = rn.Next(1, 10);
        }
    }
    return matrix;
}


int[,] Martrix = InitMatrix(rows, columns);
Console.WriteLine($"Первая матрица:");
PrintMatrix(Martrix);


int[,] InitMatrix2(int rows2, int columns2){
    int[,] matrix2 = new int[rows, columns];
    Random rn = new Random();
    for (int i = 0; i < matrix2.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++){
            matrix2[i, j] = rn.Next(1, 10);
        }
    }
    return matrix2;
}


int[,] Martrix2 = InitMatrix2(rows2, columns2);
Console.WriteLine($"Вторая матрица:");
PrintMatrix2(Martrix2);

void PrintMatrix(int[,]  Matrix){
    for (int i = 0; i < Martrix.GetLength(0); i++){
        for(int j = 0; j < Martrix.GetLength(1); j++){
            Console.Write($"{Matrix[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void PrintMatrix2(int[,]  Matrix2){
    for (int i = 0; i < Martrix2.GetLength(0); i++){
        for(int j = 0; j < Martrix2.GetLength(1); j++){
            Console.Write($"{Matrix2[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] result = InitLast(rows, columns2);

int[,] InitLast(int rows, int columns2){
    int[,] result = new int[rows, columns2];
    Random rn = new Random();
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++){
            result[i, j] = rn.Next(1, 10);
        }
    }
    return result;
}

Console.WriteLine("Произведение матриц будет следующим:");

for (int i = 0; i < result.GetLength(0); i++){
    for (int j = 0; j < result.GetLength(1); j++){
        int sum = 0;
        for (int k = 0; k < Martrix.GetLength(0); k++){
            sum += Martrix[i,k] * Martrix2[k,j];
        }
        result[i, j] = sum;
        Console.Write($"{result[i, j]} ");
    }
    Console.WriteLine();
}
