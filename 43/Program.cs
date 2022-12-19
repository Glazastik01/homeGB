Console.WriteLine("Введите значение k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение k2");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение b2");
double b2 = Convert.ToInt32(Console.ReadLine());

(double, double) GetX(double k1, double k2, double b1, double b2){
    double x = (b2-b1)/(k1-k2);
    double y = k1 * x + b1;
    return (x, y);
}

(double x1, double y1) = GetX(k1, k2, b1, b2);
Console.WriteLine($"Точка пересечения будет в месте с координатами {x1}, {y1}");