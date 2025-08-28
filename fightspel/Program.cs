// See https://aka.ms/new-console-template for more information
using System.Formats.Asn1;
using System.Net.Quic;


static void Fight()
{


    int gemsStart = 50;
    int p1Hp = 100;
    int p2Hp = 100;

    Console.WriteLine("Vad heter du?");

    string p1Name = "";
    while (p1Name.Length == 0 || int.TryParse(p1Name, out int bullshit))
    {

        p1Name = Console.ReadLine() ?? string.Empty;
        Console.WriteLine("try again buddy");
    }

    string p2Name = "Calin";

    while (p1Hp > 0 && p2Hp > 0)
    {
        Console.WriteLine($"{p1Name}: {p1Hp}");
        Console.WriteLine($"{p2Name}: {p2Hp}");
        p2Hp -= Random.Shared.Next(10, 25);
        p1Hp -= Random.Shared.Next(10, 25);

        Console.ReadLine();
    }

    if (p2Hp <= 0 && p1Hp <= 0)
    {
        p2Hp = 0;
        p1Hp = 0;
        Console.WriteLine($"{p1Name}: {p1Hp}");
        Console.WriteLine($"{p2Name}: {p2Hp}");
        Console.WriteLine("Nobody is the winner! GG");
    }

    else if (p1Hp <= 0)
    {
        p1Hp = 0;
        Console.WriteLine($"{p1Name}: {p1Hp}");
        Console.WriteLine($"{p2Name}: {p2Hp}");
        Console.WriteLine($"{p2Name} is the winner!");

        Console.WriteLine($"Do you want to revive yourself with 20 gems? You currently have {gemsStart} Gems. Y/N");
        string revive = Console.ReadLine();
        
    }
    else if (p2Hp <= 0)
    {
        p2Hp = 0;
        Console.WriteLine($"{p1Name}: {p1Hp}");
        Console.WriteLine($"{p2Name}: {p2Hp}");
        Console.WriteLine($"{p1Name} is the winner!");
    }
   


    Console.ReadLine();
}

Fight();