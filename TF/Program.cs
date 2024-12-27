
    
        double start = 0.0, end = 3.0, step = 0.2;

        Console.WriteLine("  x\t\t  y");
        Console.WriteLine("-----------------------");

        for (double x = start; x <= end; x += step)
        {
            double y = Math.Pow(x, 2) + 4 * Math.Sin(Math.PI * x);
            Console.WriteLine($"{x:F1}\t{y:F4}");
        }

        Console.ReadKey();
    

