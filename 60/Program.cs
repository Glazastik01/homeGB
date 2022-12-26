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
int columns = GetNumber("Введите глубину:");
int all = GetNumber("Введите ширину:");

int[,,] matrix = Initmatrix3d(rows, columns, all);

int[,,] Initmatrix3d(int rows, int columns, int all){
    int[,,] originmatr = new int[rows, columns, all];
    Random rn = new Random();
    for (int i = 0; i < originmatr.GetLength(0); i++){
        for (int j = 0; j < originmatr.GetLength(1); j++){
            for (int k = 0; k < originmatr.GetLength(2); k++){
                originmatr[i, j, k] = rn.Next(1, 10);
            }
        }    
    }
    return originmatr;
}

void PrintMatrix(int[,,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      Console.Write($"X({i}) Y({j}) ");
      for (int k = 0; k < matrix.GetLength(2); k++)
      {
        Console.Write( $"Z({k})={matrix[i,j,k]}; ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}


PrintMatrix(matrix);
