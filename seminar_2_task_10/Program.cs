//Seminar 2. Task 10
//

Console.Clear();

Console.Write("Введите трехзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());

//validation
while (true)
{
    if (n < 0)
        n = (-1) * n;

    if (n / 1000 < 1 && n / 100 >= 1)
    {
        break;
    }
    else
    {
        Console.Write("Введите ТРЕХЗНАЧНОЕ! число: ");
        n = Convert.ToInt32(Console.ReadLine());
    }
}

Console.Write($"Вторая цифра введенного числа: {n / 10 - ((n / 100) * 10)}");