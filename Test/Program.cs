// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число для расчета факториала!");
string strn=Console.ReadLine();
int n;
n=int.Parse(strn);
Console.WriteLine($"Вы ввели число: {n}");
long rez = 1;
for (int i = 1; i <= n; ++i)
{
    rez = rez * i;
}
Console.WriteLine($"Результат факториала :{rez}");

