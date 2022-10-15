using System;

class Ex4
{
    static void Main()
    {
        string? numbers = Console.ReadLine();
        string? sites = Console.ReadLine();
        Console.WriteLine();

        // 0882134215 0882134333 08992134215 0558123 3333 1
        // http://softuni.bg http://youtube.com http://www.g00gle.com

        try
        {
            if (numbers != null && sites != null)
            {
                INumbers Numbers = new Smartphone(numbers.Split(' '), sites.Split(' '));
                Numbers.Calling();

                ISites Sites = new Smartphone(numbers.Split(' '), sites.Split(' '));
                Sites.Browsing();
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }


        Console.ReadKey();
    }
}