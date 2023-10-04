using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text.Json.Serialization;
using System.Threading.Tasks.Dataflow;

string p1;
string p2;



Console.WriteLine("Welcome to Blades and Flip-flops!");
Thread.Sleep(2000);
Console.WriteLine("You need two players to play this game!");
Thread.Sleep(2000);
Console.WriteLine("Still, you can play by yourself if you're a lone wolf just like me!");
Thread.Sleep(4000);
Console.WriteLine("...");
Thread.Sleep(2000);
Console.WriteLine("...Alright, the rules of this game are really easy.");
Thread.Sleep(3000);
Console.WriteLine("All you need to do is exchange your fists with your opponent by pressing 'Enter'.");
Thread.Sleep(4000);
Console.WriteLine("Which side's HP(Health Points) reaches or falls below 0 loses. Easy, right?");
Thread.Sleep(3000);
Console.WriteLine("However, your HP and damage are randomized!");
Thread.Sleep(2000);
Console.WriteLine("Good luck!!");
Console.WriteLine("__________________________");
while (true)
{
    
    Random generator = new Random();
    int hp1 = generator.Next(40,100);
    int hp2 = generator.Next(40,100);
    
    Console.WriteLine("Write the P1 name:");
    p1 = Console.ReadLine();
    Console.WriteLine("Write the P2 name:");
    p2 = Console.ReadLine();
    Thread.Sleep(500);
    Console.WriteLine("Get ready " + p1 + " and " + p2 + "!");
    Console.WriteLine("__________________________");
    Console.WriteLine(""+ p1 + "'s HP: " + hp1 +"" );
    Console.WriteLine(""+ p2 + "'s HP: " + hp2 +"" );
    Thread.Sleep(1000);
    Console.WriteLine(""+ p1 +", your turn to start!!");
    while(true)
    {
        int dmg1 = generator.Next(10,75);
        int dmg2 = generator.Next(10,75);
        Console.ReadKey();
        if (hp2 > dmg1)
        {
            hp2 = hp2 - dmg1;
        }
        else if (hp2 < dmg1)
        {
            hp2 = dmg1 - hp2;
        }
        else
        {
            continue;
        }
        Console.WriteLine("" + p1 + " took a straight pucnh!!");
        if (hp2 > 0)
        {
            Console.WriteLine("" + p2 + "'s HP is now: " + hp2 +"!");
            Thread.Sleep(1000);
            Console.WriteLine("It's " + p2 + "'s turn now!" );
            Console.ReadKey();
            if (hp1 > dmg2)
            {
                hp1 = hp1 - dmg2;
            }
            else if (hp1 < dmg2)
            {
                hp1 = dmg2 - hp1;
            }
            Console.WriteLine("" + p1 + "'s HP is now: " + hp1 +"!");
            Thread.Sleep(1000);
            Console.WriteLine("It's " + p1 + "'s turn now!" );
            continue;
        }
        else if (hp2 <= 0)
        {
            Console.WriteLine("" + p2 + " was knocked down!" + p1 + " is the winner!");
            break;
        }
        else if (hp1 <= 0)
        {
            Console.WriteLine("" + p1 + " was knocked down!" + p2 + " is the winner!");
            break;
        }
        
    }

    
    break;
}
































Console.WriteLine("");
Console.WriteLine("Press any key to exit.");
Console.ReadKey();