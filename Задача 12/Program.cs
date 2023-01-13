using Задача_12;
Console.WriteLine("Введите радиус окружности");
double r = Convert.ToDouble(Console.ReadLine());
double length = Circle.GetLength(r);
double square = Circle.GetSquare(r);
Console.WriteLine($"Длина окружности равна {length}, а площадь - \n{square}");
Console.WriteLine("Введите координату точки по оси х");
double x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату точки по оси у");
double y = Convert.ToDouble(Console.ReadLine());
double tochka = Circle.GetTochka(x, y);
Console.WriteLine($"Расстояние от центра окружности до точки {tochka}");
if (tochka > r)
{
    Console.WriteLine("Заданная точка не принадлежит кругу");
}
else
    Console.WriteLine("Заданная точка принадлежит кругу");