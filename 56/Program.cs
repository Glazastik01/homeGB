
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



void PrintMatrix(int[,]  matrix){
    for (int i = 0; i < matrix.GetLength(0); i++){
        for(int j = 0; j < matrix.GetLength(1); j++){
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int rows = GetNumber("Введите количество строк:");
int columns = GetNumber("Введите количество столбцов:");

int[,] matrix = InitMatrix(rows, columns);
PrintMatrix(matrix);

int MinSum(int[,] matrix, int i){
    int sumLine = matrix[i,0];
    for (int j = 1; j < matrix.GetLength(1); j++)
    {
        sumLine += matrix[i,j];
    }
    return sumLine;
}


int MinLine = 0;
int sumLine = MinSum(matrix, 0);
for (int i = 1; i < matrix.GetLength(0); i++){
    int MinSumLine = MinSum(matrix, i);
    if (sumLine > MinSumLine){
        sumLine = MinSumLine;
        MinLine = i;
    }
}


Console.WriteLine($"{MinLine+1} строка");