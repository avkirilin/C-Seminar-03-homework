        //Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
        Console.WriteLine("Введите любое пятизначное число");
        int A = Convert.ToInt32(Console.ReadLine());
        string B = A.ToString();
        if (A > 9999 && A < 100000)
        {
            if (B[0] == B[4] && B[1] == B[3])
            {
                Console.WriteLine($"Число {A} является палиндромом");
            }
            else
            {
                Console.WriteLine($"Число {A} не является палиндромом");
            }

        }
        else
        {
            Console.WriteLine("Введенное число не является пятизначным");
        }