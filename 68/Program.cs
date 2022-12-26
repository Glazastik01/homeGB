

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

int n = GetNumber("Введите число n");
int m = GetNumber("Введите число m");

int A(int n, int m)
{
    if (n == 0){
        return m + 1;
    } else {
        if ((n != 0) && (m == 0)){
            return A(n - 1, 1);
        } else {
            return A(n - 1, A(n, m - 1));
        }
    }
}

Console.WriteLine($"A({n}, {m}) = {A(m, n)}");