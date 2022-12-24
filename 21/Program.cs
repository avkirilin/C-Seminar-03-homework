//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
        Console.WriteLine("Введите координату Х точки А");
        double x_a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите координату Y точки А");
        double y_a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите координату Z точки А");
        double z_a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите координату Х точки В");
        double x_b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите координату Y точки В");
        double y_b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите координату Z точки B");
        double z_b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"Расстояние между точками A и В = {Math.Sqrt(Math.Pow(x_b - x_a, 2) + Math.Pow(y_b - y_a, 2) + Math.Pow(z_b - z_a, 2)):f5}");