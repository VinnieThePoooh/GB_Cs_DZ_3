    // Задача 21
    // Напишите программу, которая принимает на вход координаты двух точек
    //  и находит расстояние между ними в 3D пространстве.
    // A (3,6,8); B (2,1,-7), -> 15.84
    // A (7,-5, 0); B (1,-1,9) -> 11.53

    double[] array1 = new double[3];
    double[] array2 = new double [3];
    System.Console.WriteLine("Введите X первой точки");
    array1[0] = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("Введите Y первой точки");
    array1[1] = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("Введите Z первой точки");
    array1[2] = Convert.ToInt32(Console.ReadLine());

        System.Console.WriteLine("Введите X второй точки");
        array2[0] = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Введите Y второй точки");
        array2[1] = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Введите Z второй точки");
        array2[2] = Convert.ToInt32(Console.ReadLine());

        double result = Math.Round(Math.Sqrt(Math.Pow(array1[0]-array2[0], 2) + Math.Pow(array1[1]-array2[1],2) + Math.Pow(array1[2]+array2[2],2)),2);
    System.Console.WriteLine(result);