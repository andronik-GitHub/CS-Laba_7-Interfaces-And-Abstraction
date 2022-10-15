using System;

class RebelAndCitizen : IRebel, ICitizen, IBuyer
{
    public string? Person;

    string? name;
    string? id;
    string? age;
    string? birthdate;
    string? group;
    static int food;

    public string? Name { get => name; set => name = value; }
    public string? Id { get => id; set => id = value; }
    public string? Age { get => age; set => age = value; }
    public string? Birthdate { get => birthdate; set => birthdate = value; }
    public string? Group { get => group; set => group = value; }
    public int Food { get => food; set => food = value; }

    public RebelAndCitizen (
        string? person = null,
        string? name = null,
        string? id = null,
        string? age = null,
        string? birthdate = null,
        string? group = null,
        int food = 0
        )
    {
        Person = person;
        Name = name;
        Id = id;
        Age = age;
        Birthdate = birthdate;
        Group = group;
        Food = food;

        if (Person == null)
            if (Id == null) Person = "Rebel";
            else if (Group == null) Person = "Citizen";
    }


    public void InputPerson(RebelAndCitizen[] RaC)
    {
        for (int i = 0; i < RaC.Length; i++)
        {
            Console.Write("Data: ");
            string? data = Console.ReadLine();
            string?[] str;

            if (data != null)
            {
                str = new string[data.Split(' ').Length];
                str = data.Split(' ');

                if (str.Length == 3)
                    RaC[i] = new RebelAndCitizen("Rebel")
                    { 
                        Name = str[0], 
                        Age = str[1], 
                        Group = str[2] 
                    };
                else if (str.Length == 4) 
                    RaC[i] = new RebelAndCitizen("Citizen")
                    {
                        Name = str[0], 
                        Age = str[1], 
                        Id = str[2], 
                        Birthdate = str[3]
                    };
            }
        }


        string? action = "";

        while(action?.ToLower() != "end")
        {
            Console.Write("Name or end: ");
            action = Console.ReadLine();

            if (action?.ToLower() == "end") break;

            foreach (RebelAndCitizen p in RaC)
                if (p.Name == action)
                    ((IBuyer)p).BuyFood(p.Person);
        }

        Console.WriteLine("Total amount of food purchased: " + ((IBuyer)RaC[0]).Food);
    }
}
