using System;
using System.Text;

class Commando: SpecialisedSoldier, ICommando
{
    Mission[] missions;

    public Mission[] Missions { get => missions; set => missions = value; }

    public Commando(
        string? id,
        string? firstName,
        string? lastName,
        float? salary,
        string? corps,
        Mission[] missions
        )
        : base(id, firstName, lastName, salary, corps)
    {
        this.missions = missions;
    }

    public override string ToString()
    {
        StringBuilder stringBuilder = new();
        stringBuilder.Append(base.ToString());

        stringBuilder.Append($"\nCorps: {Corps}");

        stringBuilder.Append("\nMissions:");

        if (Missions.Length != 0)
            foreach (Mission miss in Missions)
                if (miss.State?.ToLower() != "finished" && (!String.IsNullOrEmpty(miss.State) && !String.IsNullOrEmpty(miss.CodeName)))
                    stringBuilder.Append("\n      " + miss.ToString());

        return stringBuilder.ToString();
    }
}