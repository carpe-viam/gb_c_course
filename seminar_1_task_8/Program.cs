﻿//Seminar_1_task_8
//

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

for (int i = 2; i <= N; i++)
{
    if (i % 2 == 0)
    {
        Console.Write(i + " ");
    }
}