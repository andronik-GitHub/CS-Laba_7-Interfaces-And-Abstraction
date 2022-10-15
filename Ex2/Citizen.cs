using System;

class Citizen : IPerson, IBirthable, IIdentifiable
{
    string? name;
    int age;
    string? id;
    string? birthdate;

    public string? Name { get => name; set => name = value; }
    public int Age { get => age; set => age = value; }
    public string? Id { get => id; set => id = value; }
    public string? Birthdate { get => birthdate; set => birthdate = value; }

    public Citizen(string? name, int age, string? id, string? bitrhdate)
    {
        Name = name;
        Age = age;
        Id = id;
        Birthdate = bitrhdate;
    }
}