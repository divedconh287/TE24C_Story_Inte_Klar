string namn;
Console.WriteLine("Du ska gå på ett jätte spännande äventyr, men först, vad heter du?");
namn = Console.ReadLine().ToLower();
Console.WriteLine($"{namn} går in i ett rum, höger eller vänster");

    string HogerEllerVanster = "";
    while (HogerEllerVanster != "höger" && HogerEllerVanster != "vänster")
    {
    HogerEllerVanster = Console.ReadLine().ToLower();

    if (HogerEllerVanster == "höger")
    {
        Console.WriteLine($"{namn} kollar åt höger, det sitter en spegel på väggen men det står också en låda gjord av kartong i hörnet, vill du kolla in i spegeln eller kika i lådan?");
        string SpegelnEllerLadan = "";
        while (SpegelnEllerLadan != "spegeln" && SpegelnEllerLadan != "lådan")
        {
            SpegelnEllerLadan = Console.ReadLine().ToLower();

            if (SpegelnEllerLadan == "spegeln")
            { Console.WriteLine($"{namn} tittar in i spegeln som om de förväntar sig en komplimang, men spegeln säger ingenting."); }

            else if (SpegelnEllerLadan == "lådan")
            {
                Console.WriteLine($"{namn} börjar gräva i lådan & hittar en nyckel, vill {namn} spara nyckeln?");
                string Nyckel = "";
                while (Nyckel != "ja" && Nyckel != "nej")
                {
                    Nyckel = Console.ReadLine().ToLower();

                    if (Nyckel == "ja")
                    { Console.WriteLine($"{namn} tar nyckeln & lägger den i fickan, den är guld färgad & ganska dammig."); }

                    else if (Nyckel == "nej")
                    { Console.WriteLine($"{namn} lämnar nyckeln ifred & reser sig upp."); }

                    else
                    { Console.WriteLine("det är en ja eller nej fråga!"); }
                }
            }
            else
            { Console.WriteLine("Spegeln eller lådan?"); }
        }
    }

    else if (HogerEllerVanster == "vänster")
    {
        Console.WriteLine($"{namn} kollar åt vänster & ser en stor säng & en fåtölj, ska du lägga dig i sängen eller fåtöljen?");
        string SangEllerFatolj = "";
        while (SangEllerFatolj != "sängen" && SangEllerFatolj != "fåtöljen")
        {
            SangEllerFatolj = Console.ReadLine().ToLower();

            if (SangEllerFatolj == "sängen")
            { Console.WriteLine($"{namn} lägger sig i sängen & somnar."); }

            else if (SangEllerFatolj == "fåtöljen")
            {
                Console.WriteLine($"{namn} sätter sig i fåtöljen & märker att det finns något som blänker genom handtaget av kartongen på andra sidan av rummet.");
                string Nyckel0 = "";
                while (Nyckel0 != "hämta" && Nyckel0 != "lämna")
                {
                    Nyckel0 = Console.ReadLine().ToLower();
                    if (Nyckel0 == "hämta")
                    {
                        Console.WriteLine($"{namn} ställer sig upp & hämtar nyckeln.");

                        Console.WriteLine("");
                        string dörr = "";
                        while (dörr != "använd" && dörr != "nej")
                        {
                            dörr = Console.ReadLine().ToLower();
                            if (dörr == "använd")
                            { Console.WriteLine($"{namn} stoppar in nyckeln i nyckelhålet och öppnar dörren"); }
                            else if (dörr == "nej")
                            { }
                            else
                            { Console.WriteLine("ska du låsa upp den eller inte?"); }
                        }
                    }

                    else if (Nyckel0 == "lämna")
                    {
                        Console.WriteLine($"{namn} lytter nyckeln ligga kvar.");
                         Console.WriteLine("är du helt säker?");
                        string saker = "";
                        while (saker != "ja" && saker != "nej")
                        {
                            saker = Console.ReadLine().ToLower();
                            if (saker == "ja")
                            { }
                            else if (saker == "nej")
                            {
                                Console.WriteLine($"{namn} ställer sig upp & hämtar nyckeln.");
                                Console.ReadLine();
                                Console.WriteLine($"just då märker {namn} att det finns en stor dörr på den tredje väggen.");
                        string dörr = "";
                        while (dörr != "använd" && dörr != "nej")
                        {
                            dörr = Console.ReadLine().ToLower();
                            if (dörr == "använd")
                            { Console.WriteLine($"{namn} stoppar in nyckeln i nyckelhålet och öppnar dörren"); }
                            else if (dörr == "nej")
                            { }
                            else
                            { Console.WriteLine("ska du låsa upp den eller inte?"); }
                        }
                            }
                            else
                            { Console.WriteLine("ja eller nej?"); }
                        }   
                    }

                    else
                    { Console.WriteLine("tänker du bara sitta där?"); } 
            }
        }
            else
        { Console.WriteLine("sängen eller fåtöljen?"); }
        }
        }

        else
        { Console.WriteLine("höger eller vänster?"); }
    }
    Console.ReadLine();