using System;

interface ICommando : ISpecialisedSoldier
{
    Mission[] Missions { get; set; }

    void CompleteMission(Mission miss) => miss.State = "finished";
}