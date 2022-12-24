//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("Введите число N");
        int N = Convert.ToInt32(Console.ReadLine());
        int i = 0;
        Console.Write($"Таблица кубов чисел от 1 до {N}: ");
        for (i = 1; i <= N; i++)
        {
            if (i < N) Console.Write($"{Math.Pow(i, 3)}, ");
            if (i == N) Console.WriteLine(Math.Pow(i, 3));
        }