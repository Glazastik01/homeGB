int GetNumber(string message){
    int result = 0;
    while(true){
        Console.WriteLine(message);
        if(int.TryParse(Console.ReadLine(), out result)){
            break;
        } else {
            Console.WriteLine("Ввели не число");
        }
    }
    return result;
}


int rows = GetNumber("Введите высоту:");
int columns = GetNumber("Введите ширину:");

int[,] matrix = new int[rows, columns];

int num = 1;
int i = 0;
int j = 0;

if(rows == columns){
    while (num <= matrix.GetLength(0) * matrix.GetLength(1)){
        matrix[i, j] = num;
        num++;
        if (i <= j + 1 && i + j < matrix.GetLength(1) - 1){
            j++;
        } else if (i < j && i + j >= matrix.GetLength(0) - 1){
            i++;
        } else if (i >= j && i + j > matrix.GetLength(1) - 1){
            j--;
        } else {
        i--;
        }
    }
} else {
    Console.WriteLine("Невозможно выполнить действие");
}

PrintMatrix(matrix);

void PrintMatrix (int[,] matrix){
  for (int i = 0; i < matrix.GetLength(0); i++){
    for (int j = 0; j < matrix.GetLength(1); j++){
        if (matrix[i,j] / 10 <= 0){
            Console.Write($"{matrix[i,j]} ");
        } else {
            Console.Write($"{matrix[i,j]} ");
        }
    }
    Console.WriteLine();
  }
}