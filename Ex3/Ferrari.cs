using System;

class Ferrari : IFerrari
{
    const string model = "488-Spider";
    string? driversName;

    public string? Model { get => model; }
    public string? DriversName { get => driversName; set => driversName = value; }


    public Ferrari(string? driversName) { DriversName = driversName; }
}