Console.WriteLine("Введите трёхзначное число ");

    while(true)
    {
        String input = Console.ReadLine();
        if(!input.Equals("exit"))
            System.Console.WriteLine("{0}->{1}", input, input[1]);
            else
            break;
    }

