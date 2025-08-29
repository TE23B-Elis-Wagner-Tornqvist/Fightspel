// See https://aka.ms/new-console-template for more information
using System.Formats.Asn1;
using System.Net.Quic;

Fight();

static void Fight()
{


    int gems = 50;
    int p1Hp = 50;
    int p2Hp = 100;

    Console.WriteLine("Vad heter du?");

    string p1Name = "";
    while (p1Name.Length == 0 || int.TryParse(p1Name, out int bullshit))
    {
        p1Name = Console.ReadLine() ?? string.Empty;

    }

    Console.WriteLine("Vilken klass vill du använda?");

    List<string> attackClasses = new List<string>()
    {
        "Assasin: ATK SPD: Fast, DMG: Low",
        "Tank: ATK SPD: Slow, DMG: HIGH",
        "Shooter: ATK SPD: Medium: DMG: Medium"

    };

    string p2Name = "Jesus";

    (p1Hp, p2Hp) = Battle(p1Hp, p2Hp, p1Name, p2Name);


    if (p2Hp <= 0 && p1Hp <= 0)
    {
        p2Hp = 0;
        p1Hp = 0;
        Console.WriteLine($"{p1Name}: {p1Hp}");
        Console.WriteLine($"{p2Name}: {p2Hp}");
        Console.WriteLine("Nobody is the winner! GG");
    }

    else if (p2Hp <= 0)
    {
        p2Hp = 0;
        Console.WriteLine($"{p1Name}: {p1Hp}");
        Console.WriteLine($"{p2Name}: {p2Hp}");
        Console.WriteLine($"{p1Name} is the winner!");
    }
    else if (p1Hp <= 0)
    {
        p1Hp = 0;
        Console.WriteLine($"{p1Name}: {p1Hp}");
        Console.WriteLine($"{p2Name}: {p2Hp}");
        Console.WriteLine($"{p2Name} is the winner!");

        Console.WriteLine($"Do you want to revive yourself with 20 gems? You currently have {gems} Gems. Y/N");
        string revive = Console.ReadLine();
        if (revive.ToLower() == "yes")
        {
             gems -= 20;
            p1Hp = 100;
            Console.WriteLine($"Du har nu {gems} gems kvar");
           (p1Hp, p2Hp) = Battle(p1Hp, p2Hp, p1Name, p2Name);
        }

    }



    Console.ReadLine();
}









static (int, int) Battle(int p1Hp, int p2Hp, string p1Name, string p2Name)
{

    while (p1Hp > 0 && p2Hp > 0)
    {
        Console.WriteLine($"{p1Name}: {p1Hp}");
        Console.WriteLine($"{p2Name}: {p2Hp}");
        p2Hp -= Random.Shared.Next(10, 25);
        p1Hp -= Random.Shared.Next(10, 25);

        Console.ReadLine();
    }

      if (p2Hp <= 0)
    {
        p2Hp = 0;
        Console.WriteLine($"{p1Name}: {p1Hp}");
        Console.WriteLine($"{p2Name}: {p2Hp}");
        Console.WriteLine($"{p1Name} is the winner!");
    }

    return (p1Hp, p2Hp);
}