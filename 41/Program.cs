//не понял условие задачи(пользователь должен ввести размер массива или сам массив)
/*Console.Write("Введите ряд чисел через запятую: ");
string numsRow = Console.ReadLine() ?? "";
string[] strArr = numsRow.Split(",");
int[] intArr = Array.ConvertAll(strArr, int.Parse);
int k = 0;
for (int i = 0; i < intArr.Length; i++){
    if (intArr[i] > 0){
        k++;
    }
}
Console.WriteLine(k);
*/

int GetNumber(string message)
{
    int result;

    while (true)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result) && result > 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число. Введите корректное число");
        }
    }
    return result;
}

int[] InitArray(int dimension)
{
    int[] array = new int[dimension];
    Random rnd = new Random();

    for (int i = 0; i < dimension; i++)
    {
        array[i] = rnd.Next(-100, 100);
    }

    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }

    Console.WriteLine();
}

int count(int[] array){
    int k = 0;
    for (int i = 0; i < array.Length; i++){
    if (array[i] > 0){
        k++;
        }
    }
    return k;
}

int dimension = GetNumber("Введите размерность массива:");
int[] array = InitArray(dimension);
PrintArray(array);
int k = count(array);
Console.WriteLine($"Количество чисел > 0: {k}");