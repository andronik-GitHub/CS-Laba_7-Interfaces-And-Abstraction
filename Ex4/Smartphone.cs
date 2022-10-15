using System;

class Smartphone : INumbers, ISites
{
    string?[] numbers;
    string?[] sites;

    public string?[] Numbers { get => numbers; }
    public string?[] Sites { get => sites; }

    public Smartphone(string?[] numbers, string?[] sites)
    {
        this.numbers = numbers;
        this.sites = sites;
    }
}
