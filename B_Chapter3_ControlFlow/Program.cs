// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Тернарная операция в условиях!!!!
int Age = 20;
string description = Age > 18 ? "You can drink alco" : "No";

//DZ1();

static void DZ1()
{
    //ДЗ 1 Запросить у пользователя два целочисленных значения и найти максимальное.- уже делал много раз
    int a, b;
    a = int.Parse(Console.ReadLine());
    b = int.Parse(Console.ReadLine());
    int max = a > b ? a : b;
}