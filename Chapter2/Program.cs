DZ1();
DZ2();
DZ3();

static void DZ3()
{
    /*Практическое задание "Профиль пользователя"
Запросить у пользователя: фамилию, имя, возраст, вес, рост.

Рассчитать ИМТ(индекс массы тела) по формуле ИМТ = вес (кг) / (рост(м) * рост(м))

Сформировать единую строку, в следующем формате:
Your profile:
Full Name: фамилия, имя
Age: рост
Weight: вес
Height: рост
Body Mass Index: ИМТ

Вывести сформированную строку на консоль.*/
    string? fio, ages, weights, heights, profile = "You profile:";
    int age;
    double weight, height;
    Console.WriteLine("Формируем ваш профайл:");
    Console.WriteLine("Введите фамилию и имя:");

    fio = Console.ReadLine();
    if (string.IsNullOrWhiteSpace(fio)) Console.WriteLine("Значение не введено!");
    else
    {
        Console.WriteLine("Введите ваш возраст (целое):");
        ages = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(ages)) Console.WriteLine("Значение не введено!");
        else
        {
            age = int.Parse(ages);
            Console.WriteLine("Введите ваш вec (можно дробное):");
            weights = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(weights)) Console.WriteLine("Значение не введено!");
            else
            {
                weight = Double.Parse(weights);
                Console.WriteLine("Введите ваш рост в метрах (дробное):");
                heights = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(heights)) Console.WriteLine("Значение не введено!");
                else
                {
                    height = Double.Parse(heights);
                    Console.WriteLine($"{profile}{Environment.NewLine}Full Name:{fio}{Environment.NewLine}" +
                    $"Age: {age}{Environment.NewLine}" +
                    $"Weight: {weight}{Environment.NewLine}" +
                    $"Height: {height}{Environment.NewLine}" +
                    $"Body Mass Index: {weight / (height * height)}");

                }
            }
        }
    }
}
static void DZ2()
{
   /*Запросить у пользователя длины трёх сторон треугольника. Длины могут быть представлены дробными значениями.

После получения длин сторон -использовать формулу Герона для вычисления площади треугольника.

Чтобы жизнь не казалась мёдом, найдите формулу самостоятельно.

После вычисления площади - вывести результат на консоль.*/
    Console.WriteLine("Введите длины трех сторон треугольника:");
    Console.WriteLine("Введите значение первой стороны:");
    string? astr, bstr, cstr;
    double a, b, c, p, s;
    astr = Console.ReadLine();
    if (string.IsNullOrWhiteSpace(astr)) Console.WriteLine("Значение не введено!");
    else
    {
        Console.WriteLine($"Введено значение a: {astr}");
        Console.WriteLine("Введите значение второй стороны:");
        bstr = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(bstr)) Console.WriteLine("Значение не введено!");
        else
        {
            Console.WriteLine($"Введено значение b: {bstr}");
            Console.WriteLine("Введите значение третьей стороны:");
            cstr = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(cstr)) Console.WriteLine("Значение не введено!");
            else
            {
                Console.WriteLine($"Введено значение c: {cstr}");
                a = Double.Parse(astr); b = Double.Parse(bstr); c = Double.Parse(cstr);
                p = (a + b + c) / 2;
                s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                Console.WriteLine($"Площадь треугольника S={s:f2}");
            }
        }
    }
}
static void DZ1()
{
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
    string? xstr = Console.ReadLine();
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
    int number, count = 0;
    string? xnumber = Console.ReadLine();
    if (string.IsNullOrWhiteSpace(xnumber)) Console.WriteLine("Значение не введено!");
    else
    {
        number = Int32.Parse(xnumber);
        while (number != 0)
        {
            number = number / 10;
            count++;
        }
        Console.WriteLine($"Количество цифр числа равно: {count}");
    }
}