using System;
using System.Text;

class LeutenantGeneral : Private, ILeutenantGeneral
{
    Private?[] privates;
    string? privateId;

    public Private?[] Privates { get => privates; set => privates = value; }
    public string? PrivateId { get => privateId; set => privateId = value; }

    public LeutenantGeneral(
        string? id,
        string? firstName,
        string? lastName,
        float? salary,
        string? privateId,
        Private?[] privates
        )
        : base(id, firstName, lastName, salary)
    {
        this.privates = privates;
        PrivateId = privateId;
    }

    public override string ToString()
    {
        StringBuilder stringBuilder = new();
        stringBuilder.Append(base.ToString());

        stringBuilder.Append("\nPrivates:");

        string?[] temp;

        if (PrivateId != null)
        {
            temp = PrivateId.Split(' ');

            foreach (string? s in temp)
                foreach (Private? priv in privates)
                    if (s == priv?.Id)
                    {
                        stringBuilder.Append("\n      " + priv?.ToString());
                    }
        }


        return stringBuilder.ToString();
    }
}