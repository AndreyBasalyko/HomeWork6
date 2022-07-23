Console.WriteLine("Введите несколько чисел. Для того чтобы закончить, введите 'end'");
int[] mas = new int[100];
int i = 0; 
int num = 0;
string test;
int count = 0;
do
{
    test = Console.ReadLine();
    if (test == "end") break;
    mas[i] = Convert.ToInt32(test);
    if (mas[i] > 0)
    {
       ++num; 
    }
    ++i; ++count;
    } while (true);
for (int j = 0; j < count; j++)
{
   Console.Write("{0} ", mas[j]);
}
Console.Write(" -> ");
Console.Write(num);