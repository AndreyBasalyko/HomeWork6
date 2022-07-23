Console.WriteLine("Введите k1...");
int k = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b1...");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите k2...");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b2...");
int b1 = Convert.ToInt32(Console.ReadLine());
double x = -10;
do
{
    double y = Math.Round(k * x + b, 2);
    double y1 = Math.Round(k1 * x + b1, 2);
    if (y == y1)
    {
       Console.Write("(");
       Console.Write(Math.Round(x, 2));
       Console.Write(";");
       Console.Write(y);
       Console.Write(")");
       break;
    }
    else
    {
        x = x + 0.1;
    }
} while (true);
