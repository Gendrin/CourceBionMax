
/*1. Запросить имя пользователя. Вывести Hello, [имя пользователя].

2. Запросить у пользователя два целых числа и сохранить в двух переменных. Вывести значения.
Обменять значения переменных: например, если в переменной x было записано число 3, а в y число 5, сделать так, чтобы в y стало 3, а в x стало 5. Вывести значения после обмена.

3. Запросить у пользователя целое число. Вывести количество цифр числа. Например, в числе 156 - 3 цифры.*/
//1
Console.WriteLine("Введите свое имя:");
string? name = Console.ReadLine();
if (string.IsNullOrWhiteSpace(name)) Console.WriteLine("Значение не введено!");
    else Console.WriteLine($"Helo, {name}");
//2
int x, y, temp;
Console.WriteLine("Введите первое число:");
string? xstr= Console.ReadLine();
if (string.IsNullOrWhiteSpace(xstr)) Console.WriteLine("Значение не введено!");
else
{
    Console.WriteLine($"Введено значение x: {xstr}");

    x = Int32.Parse(xstr);
    Console.WriteLine("Введите второе число:");
    string? ystr = Console.ReadLine();
    if (string.IsNullOrWhiteSpace(ystr)) Console.WriteLine("Значение не введено!");
    else
    {
        Console.WriteLine($"Введено значение y: {ystr}");
        y = Int32.Parse(ystr);
        Console.WriteLine($"Введены числа x: {x}, y:{y}");
        temp = x;
        x = y; y = temp;
        Console.WriteLine($"Меняем числа местами: x: {x} y:{y}");
    }
}
//3
Console.WriteLine("Введите целое число: ");
int number, count=0;
string? xnumber = Console.ReadLine();
if (string.IsNullOrWhiteSpace(xnumber)) Console.WriteLine("Значение не введено!");
else
{
    number = Int32.Parse(xnumber);
    while (number!=0)
    {
        number = number / 10;
        count++;
    }
 Console.WriteLine($"Количество цифр числа равно: {count}");
}
