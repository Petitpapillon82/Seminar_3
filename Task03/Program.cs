//Напишите программу, которая на вход принимает координаты двух точек и находит
// расстояние между ними в 2D пространстве.
// А(3,6); В(2,1) -> 5,09
// А(7,-5); В(1,-1) -> 7,21


Console.Write("Введите x1: ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("Введите y1: ");
int y1 = int.Parse(Console.ReadLine());
Console.Write("Введите x2: ");
int x2 = int.Parse(Console.ReadLine());
Console.Write("Введите y2: ");
int y2 = int.Parse(Console.ReadLine());
double n = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

Console.Write("Расстояние равно ");
Console.WriteLine(n);


// Второй вариант решения

//Console.Clear();
//Console.WriteLine("Введите A(x, y)");
//Console.Write("x1: ");
//int x1 = int.Parse(Console.ReadLine());
//Console.Write("y1: ");
//int y1 = int.Parse(Console.ReadLine());
//Console.WriteLine("Введите B(x, y)");
//Console.Write("x2: ");
//int x2 = int.Parse(Console.ReadLine());
//Console.Write(" y2: ");
//int y2 = int.Parse(Console.ReadLine());
//Console.WriteLine(Math.Sqrt((x2 - x1)*(x2 - x1) + (y2 - y1)*(y2 - y1)));