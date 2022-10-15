using System;

class SpecialisedSoldier : Private, ISpecialisedSoldier
{
    string? corps;

    public string? Corps { get => corps; set => corps = value; }

    public SpecialisedSoldier(
        string? id,
        string? firstName,
        string? lastName,
        float? salary,
        string? corps
        )
        : base(id, firstName, lastName, salary)
    {
        Corps = corps;
    }
}