using System;

class Ex2
{
    static void Main()
    {
        string? name = Console.ReadLine();
        int age = Convert.ToInt32(Console.ReadLine());
        string? id = Console.ReadLine();
        string? birthdate = Console.ReadLine();

        IIdentifiable identifiable = new Citizen(name, age, id, birthdate);
        IBirthable birthable = new Citizen(name, age, id, birthdate);

        Console.WriteLine(identifiable.Id);
        Console.WriteLine(birthable.Birthdate);


        Console.ReadKey();
    }
}