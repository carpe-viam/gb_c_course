//Seminar 2. Task 13 ver. 2
//

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n < 0)
    n = (-1) * n;

if (n / 100 == 0)
    Console.Write("Введенное число не содержит третьей цифры!");
else
{
    int count = 0;
    int x = n;

    // узнаем кол-во разрядов во введенном числе
    while (x > 0)
    {
        x = x / 10;
        count++;
    }

    int[] numbers = new int[count];
    int ind = 0;
    while (ind < count)
    {
        numbers[ind] = n % 10;
        n = n / 10;
        ind++;
    }

    Console.WriteLine($"Третья цифра: {numbers[count-3]}");
}