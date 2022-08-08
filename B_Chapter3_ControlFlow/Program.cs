// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");




static void chapter3()
{
    //Тернарная операция в условиях!!!!
    int Age = 20;
    string description = Age > 18 ? "You can drink alco" : "No";
    //Цикл foreach - цикл по массиву который проходит без работы с индексами
    // только со значениями. Только от 0 до конца.
    int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
    foreach (var item in numbers)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine();
    // Поиск пар в массиве при сумме дающих 0
    int[] num1 = { 1, -2, -4, -2, -5, -6, 2, -1, 4, 6, 8 };
    for (int i = 0; i < num1.Length - 1; i++)
    {
        for (int j = i + 1; j < num1.Length; j++)
        {
            int atI = num1[i];
            int atJ = num1[j];
            if (atI + atJ == 0) Console.WriteLine($"Pair {atI} & {atJ} with index {i} & {j} sum = 0");
        }
    }
    // Поиск суммы триплетов в массиве дающих 0
    Console.WriteLine();
    for (int i = 0; i < num1.Length - 2; i++)
    {
        for (int j = i + 1; j < num1.Length - 1; j++)
        {
            for (int k = j + 1; k < num1.Length; k++)
            {
                int atI = num1[i];
                int atJ = num1[j];
                int atK = num1[k];
                if (atI + atJ + atK == 0) Console.WriteLine($"Trip {atI} & {atJ} & {atK} with index {i} & {j} & {k} sum = 0");
            }

        }
    }
    //while  & do while - у  do while нижняя строка заканчивается ;!!!
    // МОжно объединять case!!!
    Console.WriteLine("Введите месяц года!");
    int month = int.Parse(Console.ReadLine());

    string season = string.Empty;
    switch (month)
    {
        case 1:
        case 2:
        case 12:
            season = "Winter";
            break;
        case 3:
        case 4:
        case 5:
            season = "Spring";
            break;
        case 6:
        case 7:
        case 8:
            season = "Summer";
            break;
        case 9:
        case 10:
        case 11:
            season = "Autumn";
            break;
        default:
            throw new ArgumentException("Unexpected number of month");
    }
    Console.WriteLine(season);

    string test = "133.0";
    char[] testA = test.ToCharArray();
    char[] innumbers = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', ',' };
    //bool contains = Array.Contains(innumbers, 'u');
    var hash = new HashSet<char>(innumbers);
    if (hash.Contains(test[3]))
    {
        Console.WriteLine($"Первая введенная цифра: {test[3]} верная");
    }
    bool check = false;
    //char fchar;
    for (int i = 0; i < testA.Length; i++)
    {
        foreach (char fchar in innumbers)
        {
            if (fchar == testA[i])
            {
                check = true;
                break;
            }
            else if (testA[i] == '.')
            {
                testA[i] = ',';
            }

            else
            {
                check = false;
            }
        }
        if (!check) Console.WriteLine($"Введен неверный символ {i}:{test[i]} не является цифрой или ','");
    }
    Console.WriteLine(testA);
    string testR = new string(testA);
    Console.WriteLine($"Новая строка {testR}");
    double GetDataLongStr(string instr)
    {
        return 10;
    }

    //DZ1();
}

static void DZ1()
{
    //ДЗ 1 Запросить у пользователя два целочисленных значения и найти максимальное.- уже делал много раз
    int a, b;
    a = int.Parse(Console.ReadLine());
    b = int.Parse(Console.ReadLine());
    int max = a > b ? a : b;
}