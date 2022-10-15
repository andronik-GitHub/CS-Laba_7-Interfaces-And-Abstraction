using System;
using System.Collections;

class Person : IRobot, ICitizen
{
    public string? person;

    string? id;
    string? name;
    string? model;
    int? age;

    public string? Name { get => name; set => name = value; }
    public string? Model { get => model; set => model = value; }
    public int? Age { get => age; set => age = value; }
    public string? Id { get => id; set => id = value; }

    public Person(string? id = null, string? model = null, string? name = null, string? age = null)
    {
        Id = id;
        Model = model;
        Name = name;
        Age = Convert.ToInt32(age);

        if (String.IsNullOrEmpty(Name)) person = "Citizen";
        else person = "Robot";
    }


    public void InputPerson()
    {
        string? LineOnData = "";
        string?[] str;
        string? number;

        List<Person> persons = new();

        while (LineOnData?.ToLower() != "end")
        {
            Console.Write("Data or end: ");
            LineOnData = Console.ReadLine();


            if (LineOnData?.ToLower() == "end") break;

            if (LineOnData != null)
            {
                str = LineOnData.Split(' ');


                if (str?.Length == 2)
                    persons.Add(new Person(str[1]) { Id = str[1], Model = str[0] });
                else if (str?.Length == 3)
                    persons.Add(new Person(str[2]) { Id = str[2], Name = str[0], Age = Convert.ToInt32(str[1]) });
            }
        }

        Console.Write("Num: ");
        number = Console.ReadLine();

        foreach (Person person in persons)
            if (person != null && person.Id != null && number != null &&
                (person.Id[^3] == number[0] &&
                person.Id[^2] == number[1] &&
                person.Id[^1] == number[2]))
                Console.WriteLine("Fake ids: " + person.Id);
    }
}