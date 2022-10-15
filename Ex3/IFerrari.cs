using System;

interface IFerrari
{
    string? Model { get; }
    string? DriversName { get; set; }
    string Brakes { get => "Brakes!"; }
    string GasPedal { get => "Zadu6avam sA!"; }

    void CheckPedalToCar() => Console.WriteLine($"{Model}/{Brakes}/{GasPedal}/{DriversName}");
}