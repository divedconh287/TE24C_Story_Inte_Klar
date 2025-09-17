// skriva namn
string namn;
Console.WriteLine("Du ska gå på ett jätte spännande äventyr, men först, vad heter du?");
namn = Console.ReadLine().ToLower();
Console.WriteLine($"{namn} går in i ett rum.\ngå höger/gå vänster");

// höger eller vänster 
    string HogerEllerVanster = "";
    while (HogerEllerVanster != "gå höger" && HogerEllerVanster != "gå vänster")
    {
    HogerEllerVanster = Console.ReadLine().ToLower();

    // du går höger
    if (HogerEllerVanster == "gå höger")
    {
        Console.WriteLine($"{namn} kollar åt höger, det sitter en spegel på väggen men det står också en låda gjord av kartong i hörnet.\nkolla i spegeln/kika i lådan");
        string SpegelnEllerLadan = "";
        while (SpegelnEllerLadan != "kolla i spegeln" && SpegelnEllerLadan != "kika i lådan")
        {
            SpegelnEllerLadan = Console.ReadLine().ToLower();
            // du går höger-tittar i spegeln
            if (SpegelnEllerLadan == "kolla i spegeln")
            {
                Console.WriteLine($"{namn} tittar in i spegeln som om de förväntar sig en komplimang, men spegeln säger ingenting.");
             }
            // du går höger-tittar i lådan
            else if (SpegelnEllerLadan == "kika i lådan")
            {
                Console.WriteLine($"{namn} börjar gräva i lådan & hittar en nyckel.\nta nyckeln/lämna den ifred");
                string Nyckel = "";
                while (Nyckel != "ta nyckeln" && Nyckel != "lämna den")
                {
                    Nyckel = Console.ReadLine().ToLower();
                    
                    // du går höger-tittar i lådan-tar nyckeln
                    if (Nyckel == "ta nyckeln")
                    {
                        Console.WriteLine($"{namn} tar nyckeln & lägger den i fickan, den är guld färgad & ganska dammig.\n{namn} kollar upp och märker att det finns en stor dörr med ett nyckelhål i.\nöppna dörren/öppna inte dörren");
                        string dorr = "";
                        while (dorr != "öppna dörren" && dorr != "öppna inte dörren")
                        {
                            dorr = Console.ReadLine().ToLower();
                            // du går höger-tittar i lådan-tar nyckeln-öppnar dörren
                            if (dorr == "öppna dörren")
                            {
                                Console.WriteLine($"{namn} stoppar in nyckeln i nyckelhålet och öppnar dörren.");
                                Console.WriteLine($"På andra sidan av dörren så ser {namn} berg av guldtackor!\nWOW Grattis!");
                            }
                            // du går höger-tittar i lådan-tar nyckeln-öppnar inte dörren
                            else if (dorr == "öppna inte dörren")
                            {
                                Console.WriteLine($"{namn} står bara där");
                            }
                            // du går höger-tittar i lådan-tar nyckeln-skriver fel
                            else
                            { Console.WriteLine("Snälla gör något."); }
                        }
                    }
                    // du går höger-tittar i lådan-tar inte nyckeln
                    else if (Nyckel == "lämna den ifred")

                    {
                        Console.WriteLine("är du säker?\nja/nej");
                        string saker = "";
                        while (saker != "ja" && saker != "nej")
                        {
                            saker = Console.ReadLine().ToLower();
                            // du går höger-tittar i lådan-tar inte nyckeln-bestämd  
                            if (saker == "ja")
                            {
                                Console.WriteLine($"hejdå");
                            }
                            // du går höger-tittar i lådan-tar inte nyckeln-ändrar dig                         
                            else if (saker == "nej")
                            {
                                Console.WriteLine($"{namn} sträcker sig ned igen och tar nyckeln.");
                            }

                            else
                            {
                                Console.WriteLine("Det är en ja eller nej fråga!");
                            }
                        }
                    }
                    // du går höger-tittar i lådan-skriver fel
                    else
                    {
                        Console.WriteLine("Vill du ha den eller inte?");
                    }
                }
                // // du går höger-skriver fel
            }
            else
            { Console.WriteLine("Spegeln eller lådan?"); }
        }
    }
    // du går vänster
    else if (HogerEllerVanster == "gå vänster")
    {
        Console.WriteLine($"{namn} kollar åt vänster & ser en stor säng & en fåtölj.\nligg i sängen/sitt i fåtöljen");
        string SangEllerFatolj = "";
        while (SangEllerFatolj != "ligg i sängen" && SangEllerFatolj != "sitt i fåtöljen")
        {
            SangEllerFatolj = Console.ReadLine().ToLower();
            // du går vänster-lägger dig i sängen
            if (SangEllerFatolj == "ligg i sängen")
            { Console.WriteLine($"{namn} lägger sig i sängen & somnar."); }
            // du går vänster-sitter i fåtöljen
            else if (SangEllerFatolj == "sitt i fåtöljen")
            {
                Console.WriteLine($"{namn} sätter sig i fåtöljen & märker att det finns något som blänker genom handtaget av kartonglådan på andra sidan av rummet.\nundersök blänket/ignorera blänket");
                string Nyckel0 = "";
                while (Nyckel0 != "undersök blänket" && Nyckel0 != "ignorera blänket")
                {
                    Nyckel0 = Console.ReadLine().ToLower();
                    // du går vänster-sitter i fåtöljen-hämta nyckeln
                    if (Nyckel0 == "undersök blänket")
                    {
                        Console.WriteLine($"{namn} ställer sig upp & går fram till lådan & ser att blänket är en guldig men dammig nyckel & plockar upp den.\n{namn} kollar upp och märker att det finns en stor dörr med ett nyckelhål på den tredje väggen.\nlås upp dörren/lås inte upp dörren");
                        string dorr = "";
                        while (dorr != "lås upp dörren" && dorr != "lås inte upp dörren")
                        {
                            dorr = Console.ReadLine().ToLower();
                            // du går vänster-sitter i fåtöljen-hämta nyckeln-öppnar dörren                   
                            if (dorr == "lås upp dörren")
                            {
                                Console.WriteLine($"{namn} stoppar in nyckeln i nyckelhålet och öppnar dörren.");
                                Console.WriteLine($"På andra sidan av dörren så ser {namn} berg av guldtackor!\nWOW Grattis!");
                            }
                            // du går vänster-sitter i fåtöljen-hämta nyckeln-öppnar inte dörren                 
                            else if (dorr == "lås inte upp dörren")
                            { }
                            // du går vänster-sitter i fåtöljen-hämta nyckeln-skriver fel
                            else
                            { Console.WriteLine("ska du låsa upp den eller inte?"); }
                        }
                    }
                    // du går vänster-sitter i fåtöljen-hämtar inte nyckel
                    else if (Nyckel0 == "ignorera blänket")
                    {
                        Console.WriteLine($"{namn} ignorerar blänket.");
                        Console.WriteLine("är du helt säker?\nja/nej");
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
                                Console.WriteLine($"{namn} ställer sig upp & går fram till lådan & ser att blänket är en guldig men dammig nyckel & plockar upp den.");
                                Console.ReadLine();
                                Console.WriteLine($"just då märker {namn} att det finns en stor dörr på den tredje väggen.");
                                string dorr = "";
                                while (dorr != "använd" && dorr != "nej")
                                {
                                    dorr = Console.ReadLine().ToLower();
                                    // du går vänster-sitter i fåtöljen-hämtar inte nyckeln-ändrar dig-öppnar dörren
                                    if (dorr == "använd")
                                    {
                                        Console.WriteLine($"{namn} stoppar in nyckeln i nyckelhålet och öppnar dörren.");
                                        Console.WriteLine($"På andra sidan av dörren så ser {namn} berg av guldtackor!\nWOW Grattis!");
                                    }
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
    { Console.WriteLine("Vill du gå höger eller vänster?"); }
    }
    Console.ReadLine();