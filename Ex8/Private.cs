using System;
using System.Text;
using System.Xml.Linq;

class Private : Soldier, IPrivate, ICloneable
{
    float? salary;

    public float? Salary { get => salary; set => salary = value; }

    public Private(
        string? id, 
        string? firstName, 
        string? lastName, 
        float? salary
        ) 
        : base(id, firstName, lastName)
    {
        Salary = salary;
    }

    public object Clone()
    {
        return new Private(base.Id, base.FirstName, base.LastName, Salary);
    }

    public override string ToString()
    {
        StringBuilder stringBuilder = new();

        stringBuilder.Append(String.Format(base.ToString() + " Salary: {0:0.00}", Salary));

        return stringBuilder.ToString();
    }
}