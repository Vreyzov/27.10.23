//стр 21 №25
//Console.WriteLine("введите одну из величин первого прямоугольного параллелепипеда");
//double z = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("введите одну из величин первого прямоугольного параллелепипеда");
//double x = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("введите одну из величин первого прямоугольного параллелепипеда");
//double y = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("введите одну из величин второго прямоугольного параллелепипеда");
//double az = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("введите одну из величин второго прямоугольного параллелепипеда");
//double ax = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("введите одну из величин второго прямоугольного параллелепипеда");
//double ay = Convert.ToDouble(Console.ReadLine());
//double q = z * x * y;
//double j = az * ax * ay;
//{
//    if (q > j)
//    {
//        Console.WriteLine("первый параллелепипед больше");
//    }
//    else
//    {
//        Console.WriteLine("второй параллелепипед больше");
//    }
//}

//стр 34 №4
//Console.WriteLine("Введите натуральное число n");
//double n = Convert.ToDouble(Console.ReadLine());
//double a, b, c;
//a = 0;
//b = 0;
//c = 1;
//for (int i = 1; i <= n; i++)
//{
//    a = a + Math.Cos(i);
//    b = b + Math.Sin(i);
//    c = c * (a / b);
//}
//Console.WriteLine($"Выражение равно ={c}");

//стр 34 №11
//double a;
//double x;
//a = 1 + Math.Sin(0.1);
//for (double i = 0.2; i <= 10; i += 0.1)
//{
//    x = 1 + Math.Sin(i);
//    a = a * x;
//}
//Console.WriteLine($"Выражение равно = {a}");

//стр 39 №22
//Console.WriteLine("Введите число окончания");
//int y = Convert.ToInt32(Console.ReadLine());
//double sum = 0;
//while (y > 0)
//{
//    Console.WriteLine("Введите очередное число последовательности z=");
//    double z = Convert.ToDouble(Console.ReadLine());
//    double x = z % 10;
//    if (x / y == 1)
//    {
//        sum += z;
//    }
//    else
//    {
//        Console.WriteLine("число не оканчивается на заданное");
//    }
//    Console.WriteLine("Продолжить ввод? Y/N");
//    if (Console.ReadLine() == "N")
//    {
//        break;
//    }
//}
//Console.WriteLine($"Сумма последовательности равна = {sum}");