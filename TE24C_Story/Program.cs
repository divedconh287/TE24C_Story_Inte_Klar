string namn;
Console.WriteLine("Du ska gå på ett jätte spännande äventyr, men först, vad heter du?");
namn = Console.ReadLine().ToLower();
Console.WriteLine($"{namn} går in i ett rum, höger eller vänster");

string HögerEllerVänster = "";
while (HögerEllerVänster != "höger" && HögerEllerVänster != "vänster")
{
    HögerEllerVänster = Console.ReadLine().ToLower();

    if (HögerEllerVänster == "höger")
    { Console.WriteLine($"{namn} kollar åt höger, det sitter en spegel på väggen men det står också en låda i hörnet, vill du kolla in i spegeln eller kika i lådan?"); }

    else if (HögerEllerVänster == "vänster")
    { Console.WriteLine($"{namn} kollar åt vänster & ser en stor säng & en fåtölj, ska du lägga dig i sängen eller fåtöljen?"); }

    else
    { Console.WriteLine("höger eller vänster?"); }
} 

    string SpegelnEllerLådan = "";
while (SpegelnEllerLådan != "spegeln" && SpegelnEllerLådan != "lådan")
{
    SpegelnEllerLådan = Console.ReadLine().ToLower();

    if (SpegelnEllerLådan == "spegeln")
    { Console.WriteLine($"{namn} tittar in i spegeln som om de förväntar sig en komplimang, men spegeln säger ingenting."); }

    else if (SpegelnEllerLådan == "lådan")
    { Console.WriteLine($"{namn} börjar gräva i lådan & hittar en nyckel, vill {namn} spara nyckeln?"); }
    else
    { Console.WriteLine("Spegeln eller lådan?"); } }

        string Nyckel = "";
        while (Nyckel != "ja" && Nyckel != "nej")
        {
            Nyckel = Console.ReadLine().ToLower();

            if (Nyckel == "ja")
            { Console.WriteLine($"{namn} tar nyckeln, den är guld färgad & ganska dammig."); }

            else if (Nyckel == "nej")
            { Console.WriteLine($"{namn} lämnar nyckeln ifred & reser sig upp."); }

            else
            { Console.WriteLine("det är en ja eller nej fråga!"); }
        }
    


    string SängEllerFåtölj = "";
    while (SängEllerFåtölj != "sängen" && SängEllerFåtölj != "fåtöljen")
    {
        SängEllerFåtölj = Console.ReadLine().ToLower();

        if (SängEllerFåtölj == "sängen")
        { Console.WriteLine($"{namn} lägger sig i sängen & somnar."); }

        else if (SängEllerFåtölj == "fåtöljen")
        { Console.WriteLine($"{namn} "); }

        else
        { Console.WriteLine("sängen eller fåtöljen?"); }
    }
Console.ReadLine();