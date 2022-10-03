//Seminar_1_task_2
//
Console.Clear();
Console.Write("Введите первое число: ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int x2 = Convert.ToInt32(Console.ReadLine());

if (x1 < x2)
{
    Console.WriteLine("Второе число больше!");
}
else if (x1 > x2)
{
    Console.WriteLine("Первое число больше!");
}
else
{
    Console.WriteLine("Числа равны!");
}