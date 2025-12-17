
using System.Data;
using System.Linq.Expressions;



int playerhp = 0;
int playerhpmax = 0;
int playerdamage = 0;

int rollingrathp = 50;
int rollingratdamage = 5;

int spicyspiderhp = 250;
int spicyspiderdamage = 20;

int tremblingtrollhp = 1000;
int tremblingtrolldamage = 75;


Console.ForegroundColor = ConsoleColor.DarkCyan;
string line = "Ward: Hello fellow wanderer, are you interested in entering the dungeon?  (y/n)";
foreach (char c in line)
{
Console.Write(c);
Thread.Sleep(25);
}

Console.WriteLine();
Console.ResetColor();

bool enterdung = true;

string answer = Console.ReadLine();


while (enterdung == true)
{
    if (answer == "y")
{
    Thread.Sleep(250);
    Console.Clear();
    Thread.Sleep(250);
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    string line2 = "Ward: Alright lets get started";
    foreach (char c in line2)
    {
    Console.Write(c);
    Thread.Sleep(25);
    }

Console.WriteLine();
Console.ResetColor();

Thread.Sleep(250);
Console.Clear();
Thread.Sleep(250);

    Console.ForegroundColor = ConsoleColor.DarkCyan;
    string line3 = "Ward: Firstly, you're up against the ";
    foreach (char c in line3)
    {
    Console.Write(c);
    Thread.Sleep(25);
    }

Console.ResetColor();


    Console.ForegroundColor = ConsoleColor.Red;
    string line4 = "Rolling Rat";
    foreach (char c in line4)
    {
    Console.Write(c);
    Thread.Sleep(25);
    }

Console.WriteLine();
Console.ResetColor();

Thread.Sleep(1000);
Console.Clear();
Thread.Sleep(1000);


    Console.ForegroundColor = ConsoleColor.Green;
    string line5 = "Choose your class (1-3)";
    foreach (char c in line5)
    {
    Console.Write(c);
    Thread.Sleep(25);
    }

    Console.WriteLine();

    Console.ForegroundColor = ConsoleColor.Blue;
    string line6 = "1. Warrior";
    foreach (char c in line6)
    {
    Console.Write(c);
    Thread.Sleep(25);
    }

    Console.WriteLine();

    Console.ForegroundColor = ConsoleColor.Magenta;
    string line7 = "2. Mage";
    foreach (char c in line7)
    {
    Console.Write(c);
    Thread.Sleep(25);
    }

    Console.WriteLine();

    Console.ForegroundColor = ConsoleColor.DarkGray;
    string line8 = "3. Juggernaut";
    foreach (char c in line8)
    {
    Console.Write(c);
    Thread.Sleep(25);
    }

    Console.ResetColor();

    string clas = Console.ReadLine();

    if (clas == "1")
        {
            playerhp = 100;
            playerhpmax = 100;
            playerdamage = 25;
        }
    else if (clas == "2")
        {
            playerhp = 75;
            playerhpmax = 100;
            playerdamage = 40;
        }
    else if (clas == "3")
        {
            playerhp = 150;
            playerhpmax = 150;
            playerdamage = 15;
        }

    Console.Clear();
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine("<<<[Dungeon]>>>");
    Console.ResetColor();
    Console.WriteLine();


bool rollingratfight = true;
bool spicyspiderfight = false;

while(rollingratfight == true)
        {
            rollingrathp = 50;

            while(playerhp > 0 && rollingrathp > 0)
        {
            int Playerdamage = Random.Shared.Next(playerdamage);
            rollingrathp -= Playerdamage;
            rollingrathp = Math.Max(0, rollingrathp);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($" you did {Playerdamage} to Rolling Rat");
            Console.ResetColor();

            int enemydamage = Random.Shared.Next(20);
            playerhp -= enemydamage;
            playerhp = Math.Max(0, playerhp);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"Rolling rat did {enemydamage} to you");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"You: {playerhp} Rolling rat: {rollingrathp}");
            Console.ResetColor();

            Console.WriteLine("Continue");
            Console.ReadLine();
            Console.Clear();
        }

        if (playerhp <= 0)
    {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("You died! Want to try again? (y/n)");
            Console.ResetColor();
            string retry = Console.ReadLine().ToLower();

            if (retry == "y")
            {
                playerhp = playerhpmax;
                continue;
            }
            else
            {
                Environment.Exit(0);
            }
    }

        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("Fight again (Reward)     or     Go against the Spicy Spider     (1/2)");
        string Choice = Console.ReadLine();
        Console.Clear();
        Console.ResetColor();

        if (Choice == "1")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("You gained +50hp  +15dmg as a reward!");
                Console.Clear();
                Console.ResetColor();

                playerhpmax += 50;
                playerdamage += 15;
                playerhp = playerhpmax;
                rollingrathp = 50;

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Your new stats");
                Console.WriteLine($"HP: {playerhp}/{playerhpmax}");
                Console.WriteLine($"Damage: {playerdamage}");
                Thread.Sleep(2000);
                Console.Clear();
                Console.ResetColor();

                Thread.Sleep(2000);
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("...Prepare for next round");
                Thread.Sleep(2000);
                Console.Clear();
                Console.ResetColor();
            }

        else if (Choice == "2")
            {
                rollingratfight = false;
                spicyspiderfight = true;
                playerhp = playerhpmax;
            } 
    }



}






else if (answer == "n")
{
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    string line2 = "Ward: Very well then, if you ever change your mind just tell me (y/n)";
    foreach (char c in line2)
    {
    Console.Write(c);
    Thread.Sleep(25);
    }
    
    string changemind = Console.ReadLine();

    if (changemind == "1")
    {
        enterdung = true;
        answer = "y";
    }
    else if (changemind == "2")
        {
            enterdung = false;
            Environment.Exit(500);
        }
    }



}




Console.ReadLine();
