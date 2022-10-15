using System;
using System.Globalization;

class Ex8
{
    static void Main()
    {
        List<string> action = new() { "" };
        int actionIndex = 0;

        // Input
        while (action[actionIndex]?.ToLower() != "end")
        {
            string? temp = Console.ReadLine();

            if (temp != null)
                action.Add(temp);

            actionIndex++;
        }

        //////////////////////////////////////////////////////////////////
        /// Converting
        /// 
        int PrivatesIndex = 0;
        int SpyIndex = 0;
        int LeutenantGeneralIndex = 0;
        int EngineerIndex = 0;
        int CommandoIndex = 0;

        Private[] privates = new Private[1];
        Spy[] spys = new Spy[1];
        LeutenantGeneral[] leutenantGenerals = new LeutenantGeneral[1];
        Engineer[] engineers = new Engineer[1];
        Commando[] commandos = new Commando[1];

        for (int i = 0; i < actionIndex; i++)
        {
            string[] str;

            if (action[i] != null)
            {
                str = new string[action[i].Split(' ').Length];
                str = action[i].Split(' ');

                if (str[0]?.ToLower() == "private") PrivatesIndex++;
                else if (str[0]?.ToLower() == "spy") SpyIndex++;
                else if (str[0]?.ToLower() == "leutenantgeneral") LeutenantGeneralIndex++;
                else if (str[0]?.ToLower() == "engineer") EngineerIndex++;
                else if (str[0]?.ToLower() == "commando") CommandoIndex++;
            }
        }

        if (PrivatesIndex > 0) privates = new Private[PrivatesIndex];
        if (SpyIndex > 0) spys = new Spy[SpyIndex];
        if (LeutenantGeneralIndex > 0) leutenantGenerals = new LeutenantGeneral[LeutenantGeneralIndex];
        if (EngineerIndex > 0) engineers = new Engineer[EngineerIndex];
        if (CommandoIndex > 0) commandos = new Commando[CommandoIndex];

        PrivatesIndex = 0;
        SpyIndex = 0;
        LeutenantGeneralIndex = 0;
        EngineerIndex = 0;
        CommandoIndex = 0;


        for (int i = 0; i < actionIndex; i++)
        {
            string[] str;

            if (action[i] != null)
            {
                str = new string[action[i].Split(' ').Length];
                str = action[i].Split(' ');

                if (str[0]?.ToLower() == "private")
                {
                    privates[PrivatesIndex] = new Private(str[1], str[2], str[3], Convert.ToSingle(str[4]));
                    PrivatesIndex++;
                }
                else if (str[0]?.ToLower() == "spy")
                {
                    spys[SpyIndex] = new Spy(str[1], str[2], str[3], Convert.ToInt32(str[4]));
                    SpyIndex++;
                }
                else if (str[0]?.ToLower() == "leutenantgeneral")
                {
                    if (PrivatesIndex > 0)
                    {
                        if (str.Length > 4)
                        {
                            string temp = "";

                            for (int l = 4; l < str.Length; l++)
                                temp += str[l] + " ";

                            leutenantGenerals[LeutenantGeneralIndex] = new LeutenantGeneral(str[1], 
                                                                                            str[2], 
                                                                                            str[3], 
                                                                                            Convert.ToSingle(str[4]), 
                                                                                            temp, 
                                                                                            privates);
                        }
                        else
                            leutenantGenerals[LeutenantGeneralIndex] = new LeutenantGeneral(str[1], 
                                                                                            str[2], 
                                                                                            str[3], 
                                                                                            Convert.ToSingle(str[4]), 
                                                                                            "", 
                                                                                            privates);
                    }
                    else
                    {
                        Private[] temp = Array.Empty<Private>();
                        leutenantGenerals[LeutenantGeneralIndex] = new LeutenantGeneral(str[1], 
                                                                                        str[2], 
                                                                                        str[3], 
                                                                                        Convert.ToSingle(str[4]), 
                                                                                        "", 
                                                                                        temp);
                    }

                    LeutenantGeneralIndex++;
                }
                else if (str[0]?.ToLower() == "engineer")
                {
                    if (str.Length > 6)
                    {
                        Repair[] repairs = new Repair[(str.Length - 6) / 2];

                        for (int j = 0; j < repairs.Length; j++)
                            for (int k = 6; k < str.Length; k += 2)
                            {
                                repairs[j] = new(str[k], Convert.ToInt32(str[k + 1]));
                                j++;
                                if (j >= repairs.Length) break;
                            }


                        engineers[EngineerIndex] = new Engineer(str[1], str[2], str[3], Convert.ToSingle(str[4]), str[5], repairs);
                    }
                    else
                    {
                        Repair[] temp = Array.Empty<Repair>();
                        engineers[EngineerIndex] = new Engineer(str[1], str[2], str[3], Convert.ToSingle(str[4]), str[5], temp);
                    }

                    EngineerIndex++;
                }
                else if (str[0]?.ToLower() == "commando")
                {
                    if (str.Length > 6)
                    {
                        Mission[] missions = new Mission[(str.Length - 6) / 2];

                        for (int j = 0; j < missions.Length; j++)
                            for (int k = 6; k < str.Length; k += 2)
                            {
                                missions[j] = new(str[k], str[k + 1]);
                                j++;
                                if (j >= missions.Length) break;
                            }


                        commandos[CommandoIndex] = new Commando(str[1], str[2], str[3], Convert.ToSingle(str[4]), str[5], missions);
                    }
                    else
                    {
                        Mission[] temp = Array.Empty<Mission>();
                        commandos[CommandoIndex] = new Commando(str[1], str[2], str[3], Convert.ToSingle(str[4]), str[5], temp);
                    }

                    CommandoIndex++;
                }
            }
        }


        PrivatesIndex = 0;
        SpyIndex = 0;
        LeutenantGeneralIndex = 0;
        EngineerIndex = 0;
        CommandoIndex = 0;
        ///
        ///
        //////////////////////////////////////////////////////////////////

        // Output
        Console.WriteLine();
        for (int i = 0; i < actionIndex; i++)
        {
            string[] str;

            if (action[i] != null)
            {
                str = new string[action[i].Split(' ').Length];
                str = action[i].Split(' ');

                if (str[0]?.ToLower() == "private")
                {
                    Console.WriteLine(privates[PrivatesIndex]);
                    PrivatesIndex++;
                }
                else if (str[0]?.ToLower() == "spy")
                {
                    Console.WriteLine(spys[SpyIndex]);
                    SpyIndex++;
                }
                else if (str[0]?.ToLower() == "leutenantgeneral")
                {
                    Console.WriteLine(leutenantGenerals[LeutenantGeneralIndex]);
                    LeutenantGeneralIndex++;
                }
                else if (str[0]?.ToLower() == "engineer")
                {
                    Console.WriteLine(engineers[EngineerIndex]);
                    EngineerIndex++;
                }
                else if (str[0]?.ToLower() == "commando")
                {
                    Console.WriteLine(commandos[CommandoIndex]);
                    CommandoIndex++;
                }
            }
        }


                Console.ReadKey();
    }
}