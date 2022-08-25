//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
//5 -> 1, 4, 9, 16, 25.
//2 -> 1,4

Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()); 
int i = 1; 
while (n > 0 && i <= n)
{
Console.WriteLine("{0} в квадрате {1}", i, Math.Pow(i, 2));
 i++;   
}
Console.WriteLine();

while (n < 0 && i >= n)
{
Console.WriteLine("{0} в квадрате {1}", i, Math.Pow(i, 2));
 i--;   
}
Console.WriteLine();