//Seminar 2. Task 15
//

Console.Clear();
Console.Write("Введите номер дня недели (от 1 до 7): ");
int n = Convert.ToInt32(Console.ReadLine());

if (n == 6 || n == 7)
    Console.Write("Это выходной день :)");
else if (n >= 1 && n <= 6)
    Console.Write("Это будний день :(");
else
    Console.Write("Введенный номер не соответствует дню недели!");