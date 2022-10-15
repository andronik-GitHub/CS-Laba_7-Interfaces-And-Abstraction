using System;

class Citizen : IPerson
{
    string? name;
    int age;

    public string? Name { get => name; set => name = value; }
    public int Age { get => age; set => age = value; }

    public Citizen(string? name, int age)
    {
        Name = name;
        Age = age;
    }
}