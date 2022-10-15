using System;

class Repair : IRepair
{
    string? partName;
    int? hourWorked;

    public string? PartName { get => partName; set => partName = value; }
    public int? HourWored { get => hourWorked; set => hourWorked = value; }

    public Repair(string? partName, int? hourWorked)
    {
        PartName = partName;
        HourWored = hourWorked;
    }

    public override string ToString()
    {
        return $"Part Name: {PartName} Hour Worked: {HourWored}";
    }
}