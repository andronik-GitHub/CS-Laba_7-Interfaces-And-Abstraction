using System;

class Ex3
{
    static void Main()
    {
        string? driversName = Console.ReadLine();

        IFerrari ferrari = new Ferrari(driversName);
        ferrari.CheckPedalToCar();


        Console.ReadKey();
    }
}