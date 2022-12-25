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

void OrderArrayLines(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(1) - 1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int temp = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = temp;
        }
      }
    }
  }
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
OrderArrayLines(matrix);
PrintMatrix(matrix);

