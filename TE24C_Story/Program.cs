// skriva namn
string namn;
Console.WriteLine("Du ska gå på ett jätte spännande äventyr, men först, vad heter du?");
namn = Console.ReadLine().ToLower();
Console.WriteLine($"{namn} går in i ett rum, höger eller vänster");

// höger eller vänster 
    string HogerEllerVanster = "";
    while (HogerEllerVanster != "höger" && HogerEllerVanster != "vänster")
    {
    HogerEllerVanster = Console.ReadLine().ToLower();

// du går höger
    if (HogerEllerVanster == "höger")
    {
        Console.WriteLine($"{namn} kollar åt höger, det sitter en spegel på väggen men det står också en låda gjord av kartong i hörnet, vill du kolla in i spegeln eller kika i lådan?");
        string SpegelnEllerLadan = "";
        while (SpegelnEllerLadan != "spegeln" && SpegelnEllerLadan != "lådan")
        {
            SpegelnEllerLadan = Console.ReadLine().ToLower();
            // du går höger-tittar i spegeln
            if (SpegelnEllerLadan == "spegeln")
            { Console.WriteLine($"{namn} tittar in i spegeln som om de förväntar sig en komplimang, men spegeln säger ingenting."); }
            // du går höger-tittar i lådan
            else if (SpegelnEllerLadan == "lådan")
            {
                Console.WriteLine($"{namn} börjar gräva i lådan & hittar en nyckel, vill {namn} spara nyckeln?");
                string Nyckel = "";
                while (Nyckel != "ja" && Nyckel != "nej")
                {
                    Nyckel = Console.ReadLine().ToLower();
                    // du går höger-tittar i lådan-tar nyckeln
                    if (Nyckel == "ja")
                    {
                        Console.WriteLine($"{namn} tar nyckeln & lägger den i fickan, den är guld färgad & ganska dammig.");
                        string dorr = "";
                        while (dorr != "öppna" && dorr != "nej")
                        {
                            dorr = Console.ReadLine().ToLower();
                            // du går höger-tittar i lådan-tar nyckeln-öppnar dörren
                            if (dorr == "öppna")
                            {
                                Console.WriteLine($"{namn} ");
                            }
                            // du går höger-tittar i lådan-tar nyckeln-öppnar inte dörren
                            else if (dorr == "nej")
                            {
                                Console.WriteLine($"{namn} ");
                            }
                            // du går höger-tittar i lådan-tar nyckeln-skriver fel
                            else
                            { Console.WriteLine("öppna snälla."); }
                        }
                    }
                    // du går höger-tittar i lådan-tar inte nyckeln
                    else if (Nyckel == "nej")

                    {
                        Console.WriteLine("är du säker?");
                        string saker = "";
                        while (saker != "ja" && saker != "nej")
                        {
                            saker = Console.ReadLine().ToLower();
                            // du går höger-tittar i lådan-tar inte nyckeln-ändrar dig
                            if (saker == "ja")
                            {
                                Console.WriteLine($"{namn} ");
                            }
                            // du går höger-tittar i lådan-tar inte nyckeln-bestämd                           
                            else if (saker == "nej")
                            {
                                Console.WriteLine($"{namn} ");
                            }

                            else
                            {
                                Console.WriteLine("");
                            }
                        }
                    }
                    // du går höger-tittar i lådan-skriver fel
                    else
                    {
                        Console.WriteLine("det är en ja eller nej fråga!");
                    }
                }
            // // du går höger-skriver fel
            }
            else
            { Console.WriteLine("Spegeln eller lådan?"); }
        }
    }
// du går vänster
    else if (HogerEllerVanster == "vänster")
    {
        Console.WriteLine($"{namn} kollar åt vänster & ser en stor säng & en fåtölj, ska du lägga dig i sängen eller fåtöljen?");
        string SangEllerFatolj = "";
        while (SangEllerFatolj != "sängen" && SangEllerFatolj != "fåtöljen")
        {
            SangEllerFatolj = Console.ReadLine().ToLower();
// du går vänster-lägger dig i sängen
            if (SangEllerFatolj == "sängen")
            { Console.WriteLine($"{namn} lägger sig i sängen & somnar."); }
// du går vänster-sitter i fåtöljen
            else if (SangEllerFatolj == "fåtöljen")
            {
                Console.WriteLine($"{namn} sätter sig i fåtöljen & märker att det finns något som blänker genom handtaget av kartongen på andra sidan av rummet.");
                string Nyckel0 = "";
                while (Nyckel0 != "hämta" && Nyckel0 != "lämna")
                {
                    Nyckel0 = Console.ReadLine().ToLower();
// du går vänster-sitter i fåtöljen-hämta nyckeln
                    if (Nyckel0 == "hämta")
                    {
                        Console.WriteLine($"{namn} ställer sig upp & hämtar nyckeln.");

                        Console.WriteLine("");
                        string dorr = "";
                        while (dorr != "använd" && dorr != "nej")
                        {
                            dorr = Console.ReadLine().ToLower();
// du går vänster-sitter i fåtöljen-hämta nyckeln-öppnar dörren                     
                            if (dorr == "använd")
                            { Console.WriteLine($"{namn} stoppar in nyckeln i nyckelhålet och öppnar dörren"); }
// du går vänster-sitter i fåtöljen-hämta nyckeln-öppnar inte dörren                   
                            else if (dorr == "nej")
                            { }
                            // du går vänster-sitter i fåtöljen-hämta nyckeln-skriver fel
                            else
                            { Console.WriteLine("ska du låsa upp den eller inte?"); }
                        }
                    }
// du går vänster-sitter i fåtöljen-hämtar inte nyckeln
                    else if (Nyckel0 == "lämna")
                    {
                        Console.WriteLine($"{namn} låter nyckeln ligga kvar.");
                        Console.WriteLine("är du helt säker?");
                        string saker = "";
                        while (saker != "ja" && saker != "nej")
                        {
                            saker = Console.ReadLine().ToLower();
// du går vänster-sitter i fåtöljen-hämtar inte nyckeln-bestämd                         
                            if (saker == "ja")
                            { }
// du går vänster-sitter i fåtöljen-hämtar inte nyckeln-ändrar dig                          
                            else if (saker == "nej")
                            {
                                Console.WriteLine($"{namn} ställer sig upp & hämtar nyckeln.");
                                Console.ReadLine();
                                Console.WriteLine($"just då märker {namn} att det finns en stor dorr på den tredje väggen.");
                                string dorr = "";
                                while (dorr != "använd" && dorr != "nej")
                                {
                                    dorr = Console.ReadLine().ToLower();
// du går vänster-sitter i fåtöljen-hämtar inte nyckeln-ändrar dig-öppnar dörren
                                    if (dorr == "använd")
                                    { Console.WriteLine($"{namn} stoppar in nyckeln i nyckelhålet och öppnar dörren"); }
                                    // du går vänster-sitter i fåtöljen-hämtar inte nyckeln-ändrar dig-öppnar inte dörren
                                    else if (dorr == "nej")
                                    { }
                                    // du går vänster-sitter i fåtöljen-hämtar inte nyckeln-ändrar dig-skriver fel                            
                                    else
                                    { Console.WriteLine("ska du låsa upp den eller inte?"); }
                                }
                            }
// du går vänster-sitter i fåtöljen-hämtar inte nyckeln-skriver fel
                            else
                            { Console.WriteLine("ja eller nej?"); }
                        }
                    }
// du går vänster-sitter i fåtöljen-skriver fel
                    else
                    { Console.WriteLine("tänker du bara sitta där?"); }
                }
            }
// du går vänster-skriver fel
            else
            { Console.WriteLine("sängen eller fåtöljen?"); }
        }
    }
// höger eller vänster-skriver fel
    else
    { Console.WriteLine("höger eller vänster?"); }
    }
    Console.ReadLine();