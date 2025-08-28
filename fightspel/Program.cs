// See https://aka.ms/new-console-template for more information
using System.Formats.Asn1;
using System.Net.Quic;


 static void Fight()
{
    


int p1Hp = 100;
int p2Hp = 100;

string p1Name = "Alex";
string p2Name = "Calin";

    // for (int i = 0; i < p1Hp || i < p2Hp; i++)
    // {
    //     Console.WriteLine($"{p1Name}: {p1Hp}");
    //     Console.WriteLine($"{p2Name}: {p2Hp}");
    //     p2Hp -= Random.Shared.Next(10, 25);
    //     p1Hp -= Random.Shared.Next(10, 25);

    //     Console.ReadLine();

    // }

    while (p1Hp > 0 && p2Hp > 0)
    {
        Console.WriteLine($"{p1Name}: {p1Hp}");
        Console.WriteLine($"{p2Name}: {p2Hp}");
        p2Hp -= Random.Shared.Next(10, 25);
        p1Hp -= Random.Shared.Next(10, 25);

        Console.ReadLine();
    }

    if (p1Hp < 0)
        {
            p1Hp = 0;
            Console.WriteLine($"{p1Name}: {p1Hp}");
            Console.WriteLine($"{p2Name}: {p2Hp}");
            Console.WriteLine($"{p2Name} is the winner!");

        }
        else if (p2Hp < 0)
        {
            p2Hp = 0;
            Console.WriteLine($"{p1Name}: {p1Hp}");
            Console.WriteLine($"{p2Name}: {p2Hp}");
            Console.WriteLine($"{p1Name} is the winner!");
        }
    if (p2Hp < 0 && p1Hp < 0)
{
    p2Hp = 0;
    p1Hp = 0;
    Console.WriteLine($"{p1Name}: {p1Hp}");
    Console.WriteLine($"{p2Name}: {p2Hp}");
    Console.WriteLine("Nobody is the winner! GG");
}


    Console.ReadLine();
}

Fight();