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

// Console.Write("Enter number ");
// int finish = Convert.ToInt32(Console.ReadLine());
// int start = 1;
// int result = 0;
// while (start <= finish) {
//     result = Convert.ToInt32(Math.Pow(start,2));
//     start++;
//     Console.WriteLine(result);
// }



// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да



// Console.WriteLine("Введите 5 значное число");
// int number = Convert.ToInt32(Console.ReadLine());

// int firstDigit = number / 10000;
// int lastDigit = number % 10;
// int secondDigit = (number / 1000) % 10;
// int fourthDigit = (number / 10) % 10;

// if (firstDigit == lastDigit && secondDigit == fourthDigit) {
//     Console.WriteLine("Да");
// } else Console.WriteLine("Нет");



// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53



// Console.WriteLine("Введите координаты x1");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты x2");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты y1");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты y2");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты z1");
// int z1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты z2");
// int z2 = Convert.ToInt32(Console.ReadLine());

// double result = Math.Round(Math.Sqrt((Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2))), 2);

// Console.WriteLine(result);



// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125



Console.Write("N = ");
int N = Convert.ToInt32(Console.ReadLine());
int i = 1;
int number = 1;

Console.Write(N + " -> ");

while(i <= N) {
    int result = Convert.ToInt32(Math.Pow(number, 3));
    Console.Write(result + ", ");
    i++;
    number++;
}