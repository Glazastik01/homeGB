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

int n = GetNumber("Введите число");

int[] arr = new int[n];

int m = 1;

if (n < 1){
    Console.WriteLine("Ввели не положительное число");
}
Console.WriteLine(Recurs(n, m));

int Recurs(int n, int m)
{
    if (n == m)
        return n;
    else
        Console.Write($"{Recurs(n, m + 1)}, ");
    return m;
}