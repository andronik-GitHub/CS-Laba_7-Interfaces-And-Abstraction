using System;

interface IEngineer : ISpecialisedSoldier
{
    Repair[] Repairs { get; set; }
}