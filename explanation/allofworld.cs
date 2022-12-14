/*Console.WriteLine("Введите первое число: ");
string a1 = Console.ReadLine();
int a = Convert.ToInt32(a1);
Console.WriteLine("Введите второе число: ");
string b1 = Console.ReadLine();
int b = Convert.ToInt32(b1);

if (a > b){
    int max = a;
    int min = b;
    Console.WriteLine("max: " + max + "; min: " + min);
} else if (a < b) {
    int max = b;
    int min = a;
    Console.WriteLine("max: " + max + "; min: " + min);
} else if (a == b) {
    Console.WriteLine("Числа равны");
}*/

/*Console.WriteLine("Введите первое число: ");
string a1 = Console.ReadLine();
int a = Convert.ToInt32(a1);
Console.WriteLine("Введите второе число: ");
string b1 = Console.ReadLine();
int b = Convert.ToInt32(b1);
Console.WriteLine("Введите третье число: ");
string c1 = Console.ReadLine();
int c = Convert.ToInt32(c1);

if (a > b){
    int max = a;
    if (max > c){
        max = max;
        Console.WriteLine("Максимальное: " + max);
    } else {
        max = c;
        Console.WriteLine("Максимальное: " + max);
    }
} else {
    int max = b;
    if (max > c){
        max = max;
        Console.WriteLine("Максимальное: " + max);
    } else {
        max = c;
        Console.WriteLine("Максимальное: " + max);
    }
}*/

/*Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a % 10 == 0){
    Console.WriteLine("Число является чётным");
} else {
    Console.WriteLine("Число не является чётным");
}*/


/*Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
int b = 1;
while(b <= a){
    if (b % 2 == 0){
        Console.WriteLine(b);
    }
    b += 1;
}*/





/* int GetRandomNumber(int Left, int Right){
    Random rnd = new Random();
    int number = rnd.Next(Left, Right + 1);
    return number;
}

int GetMaxDigitOfNumber(int number){
    int firstDigit = number / 10;
    int secondDigit = number % 10;
    
    if(firstDigit > secondDigit)
        return firstDigit;
    else
        return secondDigit;
}

int number = GetRandomNumber(10, 99);

Console.WriteLine($"Сгенерированное число: {number}");

int maxDigit = GetMaxDigitOfNumber(number);

Console.WriteLine($"Наибольшая цифра числа: {maxDigit}");
*/


/*int GetRandomNumber (){
    return new Random().Next(100, 1000);
}


void ShowRandomNumber2 (int number){
    Console.WriteLine($"Сгенерированное рандомное число: {number}");
    int num = ((number / 100) * 10) + (number % 10);
    Console.WriteLine(num);
}

ShowRandomNumber2(GetRandomNumber());
*/


/*void Number (int a){
    if ((a % 23 == 0) && (a % 7 == 0)) Console.WriteLine($"Число {a} кратно одновременно 7 и 23");
    else Console.WriteLine($"Число {a} одновременно не кратно 7 и 23");
}

Number(11);
*/

/*void sqr(int first, int second){
    double sq = Math.Pow(first, 2);
    double sq1 = Math.Pow(second, 2);
    if (sq == second){
        Console.WriteLine($"Число {first} является квадратом {second}");
    }
    else if (sq1 == first){
        Console.WriteLine($"Число {second} является квадратом {first}");
    }
    else {
        Console.WriteLine("Числа не являются квадратами друг друга");
    }

}

sqr(7, 6);
*/

//Задача 1 из домашки на 02.12.22
/*void GetRandomNumber(int a){

    int number = ((a % 100) / 10);
    Console.WriteLine(number);

}

GetRandomNumber(134);
*/

// Задача 2 из домашки на 02.12.22

/*void GetNumber(int num){
    
    if ((num >= 100) && (num <= 999)){
        int LastNum = (num % 10);
        Console.WriteLine(LastNum);
    } else if ((num > 999)){
        int len = num.ToString().Length;
        int pow = (int)Math.Pow(10, len - 3); 
        double ThirdN = ((num / pow) % 10);
        Console.WriteLine(ThirdN);
    } else {
        Console.WriteLine("Число не трёхзначное");
    }
    
}

GetNumber(12345);
*/

// Задача 3 из домашки на 02.12.22
/*
void GetNumber(int num){
    if (num < 6 && num > 0){
        Console.WriteLine("Нет");
    } else if (num > 5 && num < 8){
        Console.WriteLine("Да");
    }
}

int num = Convert.ToInt32(Console.ReadLine());
GetNumber(num);
*/




/*
int GetNumber(string message){

    bool isCorrect = false;
    int result = 0;

    while(!isCorrect){
        
        Console.WriteLine(message);
        if(int.TryParse(Console.ReadLine(), out result) && result != 0 ){
            isCorrect = true;
        } else {
            Console.WriteLine("Ввели некорректное число");
        }
    }

    return result;
}


int GetQuarter(int x, int y)
{
    if(x > 0 && y > 0)
        return 1;
    if(x < 0 && y > 0)
        return 2;
    if(x < 0 && y < 0)
        return 3;

    return 4;
}

int x = GetNumber("Введите координату х:");
int y = GetNumber("Введите координату y:");
int quarter = GetQuarter(x, y);

Console.WriteLine($"Точка с координатами ({x}, {y}) лежит в {quarter} четверти");
*/

//Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

/*
string Method(int qua){
    switch(qua){
        case 1:
            return "x = 0 ... +беск\ny = 0 ... +беск";
            break;
        case 2:
            return "x = 0 ... +беск\ny = 0 ... +беск";
            break;
        case 3:
            return "x = 0 ... +беск\ny = 0 ... +беск";
            break;
        case 4:
            return "x = 0 ... +беск\ny = 0 ... +беск";
            break;
        default:
            return "Введите чило от 1 до 4";
    }
}

Console.WriteLine($"Диапазон чисел на заданой четверти равна: {Method(1)}");
*/

//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

//A (3,6); B (2,1) -> 5,09 
//A (7,-5); B (1,-1) -> 7,21

/*
Console.WriteLine("Введите значение X первой точки");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение Y первой точки");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение X второй точки");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение Y второй точки");
int y2 = Convert.ToInt32(Console.ReadLine());

double DistXY(int x1, int y1, int x2, int y2){

    double result = 0;
    result = Math.Sqrt(Math.Pow((x1-x2), 2) + Math.Pow((y1-y2), 2));
    return result;
}

Console.WriteLine($"Расстояние между точками = {DistXY(x1,y1,x2,y2)}");
*/

//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

//5 -> 1, 4, 9, 16, 25.
//2 -> 1,4

/*
Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= N; i++)
{
    Console.Write($"{Math.Pow(i, 2)}, ");
}
*/

//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Задача 1 из дз на 07.12.22
/*
Console.WriteLine("Введите пятизначное число");

try{
    int num = Convert.ToInt32(Console.ReadLine());
    int num_orig = num;
    int rev = 0;
    while(num > 0){
        int dig = 0;
        dig = num % 10;
        rev = rev * 10 + dig;
        num = num / 10;
    }
    if (num_orig == rev){
        Console.WriteLine("Число палиндром");
    } else {
        Console.WriteLine("Число не палиндром");
    }
} catch (Exception ex){
    Console.WriteLine("Некорректный ввод", ex);
}
*/


//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

//Задача 2 из дз на 07.12.22

/*
Console.WriteLine("Введите значение X первой точки");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение Y первой точки");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение X второй точки");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение Y второй точки");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение Z первой точки");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение Z второй точки");
int z2 = Convert.ToInt32(Console.ReadLine());

double DistXY(int x1, int y1, int z1, int x2, int y2, int z2){

    double result = 0;
    result = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2-y1), 2) + Math.Pow((z2 - z1), 2));
    return result;
}

Console.WriteLine($"Расстояние между точками = {DistXY(x1,y1,x2,y2,z1,z2)}");
*/
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

//Задача 3 из дз на 07.12.22
/*
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
double num_orig = num;
int x = 0;
while (x <= num){
    num_orig = Math.Pow(x, 3);
    x++;
    Console.Write(num_orig + ", ");
}
*/

//Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
//456 -> 3
//78 -> 2
//89126 -> 5
/*
int GetNumber(string message){

    bool isCorrect = false;
    int result = 0;

    while(!isCorrect){
        
        Console.WriteLine(message);
        if(int.TryParse(Console.ReadLine(), out result) && result != 0 ){
            isCorrect = true;
        } else {
            Console.WriteLine("Ввели некорректное число");
        }
    }

    return result;
}

int GetLenght(int number)
{
    var count = 0;
      int num = number;
    
    while(num > 0)
    {
        num = num / 10;
        count++;
    }
    return count;
}

int x = GetNumber("Введите число");

int len = GetLenght(x);

Console.WriteLine($"Число {x} длинной {len}");
*/

//Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
//4 -> 24 
//5 -> 120
/*
int GetNumber(string message){

    bool isCorrect = false;
    int result = 0;

    while(!isCorrect){
        
        Console.WriteLine(message);
        if(int.TryParse(Console.ReadLine(), out result) && result != 0 ){
            isCorrect = true;
        } else {
            Console.WriteLine("Ввели некорректное число");
        }
    }

    return result;
}

int GetFact(int number){
    
    int res = 1;
    for (int i = 1; i <= number; i++){
        res = i * res;
    } 
    return res;
}
int x = GetNumber("Введите число");
int f = GetFact(x);
Console.WriteLine($"Факториалом числа {x} является {f}");
*/

//Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
//[1,0,1,1,0,1,0,0]
/*
int[] numbers = new int[8];
Random rnd = new Random();

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = rnd.Next(0, 2);
}
for (int i = 0; i < numbers.Length; i++)
{
    Console.Write(numbers[i] +" ");
}
*/
/*
int[] numbers = new int[8];
Random rnd = new Random();

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = rnd.Next(0, 2);
}
string d = String.Join(",", numbers);

Console.WriteLine(d);
*/

//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

//Задача 1 из дз на 09.12.22
/*
Console.WriteLine("Введите число");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень");
int p = Convert.ToInt32(Console.ReadLine());

int pow = (int)Math.Pow(x, p);
Console.WriteLine($"Число {x} в степени {p} будет равно {pow}");
*/

//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

//Задача 2 из дз на 09.12.22

/*
Console.WriteLine("Введите число");
try{
    int num = Convert.ToInt32(Console.ReadLine());
    int num_orig = num;
    int rev = 0;
    while(num > 0){
        int dig = 0;
        dig = num % 10;
        rev = rev + dig;
        num = num / 10;
    }
    Console.WriteLine(rev);
} catch (Exception ex){
    Console.WriteLine("Некорректный ввод", ex);
}
*/

//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

//Задача 3 из дз на 09.12.22

/*
int[] arr = new int[8];

Random rnd = new Random();

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(0, 1000);
}
string d = String.Join(",", arr);

Console.WriteLine(d);
*/


//Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
//Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

/*
int GetNumber(string message)
{
    int result;

    while(true)
    {
        Console.WriteLine(message);
        
        if(int.TryParse(Console.ReadLine(), out result) && result > 0)
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

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }

    Console.WriteLine();
}


//получить заполненный массив рандомными числами
int[] InitArray(int dimension)
{
    int[] array = new int[dimension];
    Random rnd = new Random();

    for (int i = 0; i < dimension; i++)
    {
        array[i] = rnd.Next(-20, 20);
    }

    return array;
}

(int, int) GetSumms(int[] array)
{
    int positiveSumm = 0;
    int negativeSumm = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < 0)
            negativeSumm += array[i];
        else
            positiveSumm += array[i];
    }

    return (positiveSumm, negativeSumm);
}

int dimension = GetNumber("Введите размерность массива:");
int[] array = InitArray(dimension);
PrintArray(array);


(int posSum, int negSum) = GetSumms(array);

Console.WriteLine($"Сумма отрицательных: {negSum}, сумма положительных: {posSum}");
*/


//Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2]

/*
int[] Invert(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * (-1);
    }
    return array;
}

int[] RandomIntegers(int min, int max, int size = 10)
{
    int[] array = new int[size];
    Random r = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = r.Next(min, max + 1);
    }
    return array;
}

int[] numbers = RandomIntegers(min: -10, max: 10, size: 5);
Console.WriteLine(string.Join(" ", numbers));
Console.WriteLine(string.Join(" ", Invert(numbers)));
*/

//Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
//4; массив [6, 7, 19, 345, 3] -> нет
//-3; массив [6, 7, 19, 345, 3] -> да

/*
void Nums(int[] array, int target){
    for(int i = 0; i < array.Length; i++){
        if (array[i] == target){
            Console.WriteLine($"Число {target} есть в массиве");
            return;
        } else {
            Console.WriteLine($"Числа {target} нет в массиве");
            return;
        }
    }
}

Nums(array: new int[] {1, 2, 3, 4, 5}, target: 6);
*/

//Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
//Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
//[5, 18, 123, 6, 2] -> 1
//[1, 2, 3, 6, 2] -> 0
//[10, 11, 12, 13, 14] -> 5

/*
int Count(int[] array, int min, int max){
    int res = 0;
    for(int i = 0; i < array.Length; i++){
        if (array[i] >= min && array[i] <= max){
            res++;
        }
    }
    return res;
}

int[] InitArray(int dimension)
{
    int[] array = new int[dimension];
    Random rnd = new Random();

    for (int i = 0; i < dimension; i++)
    {
        array[i] = rnd.Next(-20, 20);
    }

    return array;
}
int[] a = InitArray(23);
Console.WriteLine(String.Join(" ", a));
Console.WriteLine(Count(a, 10, 99));
*/
/*
int GetNumber(string message)
{
    int result;

    while(true)
    {
        Console.WriteLine(message);
        
        if(int.TryParse(Console.ReadLine(), out result) && result > 0)
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
        array[i] = rnd.Next(-20, 20);
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


int[] arr = InitArray(GetNumber("Введите число:"));

int len;

bool x;

if(arr.Length % 2 == 0){
    len = arr.Length / 2;
} else {
    len = arr.Length / 2 + 1;
}

int[] result = new int [len];

for(int i = 0; i < len; i++){
    if(i == arr.Length - 1 - i){
        result[i] = arr[i];
    } else {
        result[i] = arr[i] * arr[arr.Length - 1 - i];
    }
}
PrintArray(arr);
PrintArray(result);
*/