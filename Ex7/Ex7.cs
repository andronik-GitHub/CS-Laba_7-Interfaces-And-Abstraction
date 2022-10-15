using System;

class Ex7
{
    static void Main()
    {
        int N = Convert.ToInt32(Console.ReadLine());

        RebelAndCitizen[] RaC = new RebelAndCitizen[N];
        RebelAndCitizen p = new();

        p.InputPerson(RaC);


        Console.ReadKey();
    }
}