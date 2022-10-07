//Seminar 2. Task 13 ver. 1
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
    string nStr = Convert.ToString(n);
    Console.WriteLine($"Третья цифра введенного числа: {nStr[2]}");
}