using System;

interface ISites
{
    string?[] Sites { get; }

    void Browsing()
    {
        foreach (string? sites in Sites)
            if (!string.IsNullOrEmpty(sites) && Sites.Length != 0)
            {
                int index = 0;
                if (sites is not null)
                    foreach (char s in sites)
                        if (Char.IsDigit(s))
                        {
                            Console.WriteLine("Invalid URL!");
                            break;
                        }
                        else index++;

                if (index == sites?.Length)
                    Console.WriteLine("Browsing... " + sites);
            }
    }
}
