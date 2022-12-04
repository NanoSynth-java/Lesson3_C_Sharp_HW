// Console.WriteLine("Введите координаты по оси Х ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты по оси Y ");
// int y = Convert.ToInt32(Console.ReadLine());

// if ((x > 0) && (y > 0)) 
// {
//     Console.WriteLine("1 четверть");
// }
// if ((x < 0) && (y > 0)) 
// {
//     Console.WriteLine("2 четверть");
// }
// if ((x < 0) && (y < 0))
// {
//     Console.WriteLine("3 четверть");
// }
// if ((x > 0) && (y < 0))
// {
//     Console.WriteLine("4 четверть");
// } 

// Console.Write("x1 ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("y1 ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("x2 ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("y2 ");
// int y2 = Convert.ToInt32(Console.ReadLine());

// double d = Math.Sqrt(Math.Pow(x2 - x1,2) + Math.Pow(y2 - y1, 2)); // Math.Sqrt() находит корень числа. Math.Pow() находит степень числа.
// Console.WriteLine("Расстояние между 2 точками " + Math.Round(d));

Console.Write("Enter number ");
int finish = Convert.ToInt32(Console.ReadLine());
int start = 1;
int result = 0;
while (start <= finish) {
    result = Convert.ToInt32(Math.Pow(start,2));
    start++;
    Console.WriteLine(result);
}