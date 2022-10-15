using System;
using System.Text;

class Engineer : SpecialisedSoldier, IEngineer
{
    Repair[] repairs;

    public Repair[] Repairs { get => repairs; set => repairs = value; }

    public Engineer(
        string? id,
        string? firstName,
        string? lastName,
        float? salary,
        string? corps,
        Repair[] repairs
        )
        : base(id, firstName, lastName, salary, corps)
    {
        this.repairs = repairs;
    }

    public override string ToString()
    {
        StringBuilder stringBuilder = new();
        stringBuilder.Append(base.ToString());

        stringBuilder.Append($"\nCorps: {Corps}");

        stringBuilder.Append("\nRepairs:");

        foreach (Repair rep in repairs)
            stringBuilder.Append("\n      " + rep.ToString());

        return stringBuilder.ToString();
    }
}