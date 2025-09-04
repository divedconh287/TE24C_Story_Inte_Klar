string namn;
Console.WriteLine("Du ska gå på ett jätte spännande äventyr, men först, vad heter du?");
namn = Console.ReadLine().ToLower();
Console.WriteLine($"{namn} går in i ett rum, höger eller vänster");

string HogerEllerVanster = "";
while (HogerEllerVanster != "höger" && HogerEllerVanster != "vänster")
{
    HogerEllerVanster = Console.ReadLine().ToLower();

    if (HogerEllerVanster == "höger")
    { Console.WriteLine($"{namn} kollar åt höger, det sitter en spegel på väggen men det står också en låda i hörnet, vill du kolla in i spegeln eller kika i lådan?"); }

    else if (HogerEllerVanster == "vänster")
    { Console.WriteLine($"{namn} kollar åt vänster & ser en stor säng & en fåtölj, ska du lägga dig i sängen eller fåtöljen?"); }

    else
    { Console.WriteLine("höger eller vänster?"); }
} 

    string SpegelnEllerLadan = "";
while (SpegelnEllerLadan != "spegeln" && SpegelnEllerLadan != "lådan")
{
    SpegelnEllerLadan = Console.ReadLine().ToLower();

    if (SpegelnEllerLadan == "spegeln")
    { Console.WriteLine($"{namn} tittar in i spegeln som om de förväntar sig en komplimang, men spegeln säger ingenting."); }

    else if (SpegelnEllerLadan == "lådan")
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
    


    string SangEllerFatolj = "";
    while (SangEllerFatolj != "sängen" && SangEllerFatolj != "fåtöljen")
    {
        SangEllerFatolj = Console.ReadLine().ToLower();

        if (SangEllerFatolj == "sängen")
        { Console.WriteLine($"{namn} lägger sig i sängen & somnar."); }

        else if (SangEllerFatolj == "fåtöljen")
        { Console.WriteLine($"{namn} "); }

        else
        { Console.WriteLine("sängen eller fåtöljen?"); }
    }
Console.ReadLine();