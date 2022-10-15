using System;

interface IBuyer
{
    int Food { get; set; }

    void BuyFood(string? person)
    {
        if (person?.ToLower() == "citizen") Food += 10;
        else if (person?.ToLower() == "rebel") Food += 5;
    }
}