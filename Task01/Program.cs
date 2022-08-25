//Напишите программу, которая по заданному номеру четверти показывает
// диапазон возможных координат точек в этой четверти (x и y).

Console.Clear();
Console.Write("Введите номер четверти: ");
int x = Convert.ToInt32(Console.ReadLine());
if (x==1)
Console.WriteLine($"Диапазон значений в {x} четверти: (x;y)");
else if (x==2)
Console.WriteLine($"Диапазон значений в {x} четверти: (x;-y)");
else if (x==3)
Console.WriteLine($"Диапазон значений в {x} четверти: (-x;-y)");
else if (x==4)
Console.WriteLine($"Диапазон значений в {x} четверти: (-x;y)");
else
Console.WriteLine($"Ошибка ввода, введите цифру от 1 до 4");