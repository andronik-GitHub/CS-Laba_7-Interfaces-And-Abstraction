using System;

class Spy : Soldier, ISpy
{
    int? codeNumber;

    public int? CodeNumber { get => codeNumber; set => codeNumber = value; }

    public Spy(
        string? id,
        string? firstName,
        string? lastName,
        int? codeNumber
        )
        : base(id, firstName, lastName)
    {
        CodeNumber = codeNumber;
    }

    public override string ToString()
    {
        return String.Format(base.ToString() + "\nCode Number: {0}", CodeNumber);
    }
}