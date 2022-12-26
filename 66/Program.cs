Random r = new Random();


int rand1 = r.Next(1, 5);
int rand2 = r.Next(5, 11);

Console.WriteLine($"Начало сложения начинается с числа {rand1}");
Console.WriteLine($"Конец сложения будет {rand2}");

int sum = 0;
while (rand1 <= rand2){
    sum = rand1 + sum;
    rand1++;
    Console.Write($"{sum} ");
}
Console.WriteLine();
Console.WriteLine($"Конечное число {sum}");