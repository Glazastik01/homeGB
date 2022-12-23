

int[,] arr = new int[3, 4];

Random r = new Random();

for (int i = 0; i < 3; i++)
{
    for (int k = 0; k < 4; k++)
    {
        arr[i, k] = r.Next(-10, 10);
        Console.Write("{0}\t", arr[i, k]);
    }
    Console.WriteLine();
}