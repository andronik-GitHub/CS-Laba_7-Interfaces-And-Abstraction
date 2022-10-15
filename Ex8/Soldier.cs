using System;
using System.Text;

abstract class Soldier : ISoldier
{
    string? id;
    string? firstName;
    string? lastName;

    public string? Id { get => id; set => id = value; }
    public string? FirstName { get => firstName; set => firstName = value; }
    public string? LastName { get => lastName; set => lastName = value; }

    public Soldier(string? id, string? firstName, string? lastName)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
    }

    public override string ToString()
    {
        StringBuilder stringBuilder = new();

        stringBuilder.Append(String.Format($"Name: {FirstName} {LastName} Id: {Id}"));

        return stringBuilder.ToString();
    }
}