using System;

class Ex1
{
    static void Main()
    {
        string? name = Console.ReadLine();
        int age = Convert.ToInt32(Console.ReadLine());

        IPerson person = new Citizen(name, age);
        Console.WriteLine(person.Name);
        Console.WriteLine(person.Age);

        Console.ReadKey();
    }
}