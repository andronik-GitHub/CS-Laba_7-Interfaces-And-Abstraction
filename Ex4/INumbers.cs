using System;

interface INumbers
{
    string?[] Numbers { get; }

    void Calling()
    {
        foreach (string? numbers in Numbers)
            if (!string.IsNullOrEmpty(numbers) && Numbers.Length != 0)
            {
                int index = 0;
                if (numbers is not null)
                    foreach (char s in numbers)
                        if (!Char.IsDigit(s))
                        {
                            Console.WriteLine("Invalid number!");
                            break;
                        }
                        else index++;

                if (index == numbers?.Length)
                    Console.WriteLine("Calling... " + numbers);
            }
    }
}
