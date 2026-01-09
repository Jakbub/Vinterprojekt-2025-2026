
using System.Data;
using System.Linq.Expressions;



int playerhp = 0;
int playerhpmax = 0;
int playerdamage = 0;

int rollingrathp = 50;
int rollingratdamage = 5;

int spicyspiderhp = 250;
int spicyspiderdamage = 40;

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
    string line5 = "Choose your class  (dmg/hp)  (1-3)";
    foreach (char c in line5)
    {
    Console.Write(c);
    Thread.Sleep(25);
    }

    Console.WriteLine();

    Console.ForegroundColor = ConsoleColor.Blue;
    string line6 = "1. Warrior  100/25";
    foreach (char c in line6)
    {
    Console.Write(c);
    Thread.Sleep(25);
    }

    Console.WriteLine();

    Console.ForegroundColor = ConsoleColor.Magenta;
    string line7 = "2. Mage  75/40";
    foreach (char c in line7)
    {
    Console.Write(c);
    Thread.Sleep(25);
    }

    Console.WriteLine();

    Console.ForegroundColor = ConsoleColor.DarkGray;
    string line8 = "3. Juggernaut  150/15";
    foreach (char c in line8)
    {
    Console.Write(c);
    Thread.Sleep(25);
    }

    Console.ResetColor();
    Console.WriteLine();

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
            playerhpmax = 75;
            playerdamage = 40;
        }
    else if (clas == "3")
        {
            playerhp = 150;
            playerhpmax = 150;
            playerdamage = 15;
        }
    Console.Clear();
    Thread.Sleep(1000);
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine("<<<[Dungeon]>>>");
    Console.ResetColor();
    Console.WriteLine();
    Thread.Sleep(1000);


bool rollingratfight = true;
bool spicyspiderfight = true;

static void ratfight(ref int playerhp, ref int playerhpmax, ref int playerdamage)
{

bool rollingratfight = true;
bool spicyspiderfight = true;

int rollingrathp = 50;
int rollingratdamage = 5;

int spicyspiderhp = 250;
int spicyspiderdamage = 40;

int tremblingtrollhp = 1000;
int tremblingtrolldamage = 75;


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

            int enemydamage = Random.Shared.Next(5);
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
                Console.WriteLine("ok, goodbye");
                Thread.Sleep(1000);
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

ratfight(ref playerhp, ref playerhpmax, ref playerdamage);


    Console.ForegroundColor = ConsoleColor.DarkCyan;
    string line9 = "Ward: Looks like you're ready for someone else";
    foreach (char c in line9)
    {
    Console.Write(c);
    Thread.Sleep(25);
    }

Console.ResetColor();

Thread.Sleep(1000);
Console.Clear();
Thread.Sleep(1000);


    Console.ForegroundColor = ConsoleColor.DarkCyan;
    string line10 = "Ward: Get ready to go against the ";
    foreach (char c in line10)
    {
    Console.Write(c);
    Thread.Sleep(25);
    }

Console.ResetColor();


    Console.ForegroundColor = ConsoleColor.Red;
    string line11 = "Spicy Spider";
    foreach (char c in line11)
    {
    Console.Write(c);
    Thread.Sleep(25);
    }

Console.WriteLine();
Console.ResetColor();

Thread.Sleep(1000);
Console.Clear();
Thread.Sleep(1000);


static void spiderfight(ref int playerhp, ref int playerhpmax, ref int playerdamage)
{
            
bool rollingratfight = true;
bool spicyspiderfight = true;
bool tremblingtrollfight = true;

int rollingrathp = 50;
int rollingratdamage = 5;

int spicyspiderhp = 250;
int spicyspiderdamage = 40;

int tremblingtrollhp = 1000;
int tremblingtrolldamage = 75;

while (spicyspiderfight)
    {
         spicyspiderhp = 250;

            while(playerhp > 0 && spicyspiderhp > 0)
        {
            int Playerdamage = Random.Shared.Next(playerdamage);
            spicyspiderhp -= Playerdamage;
            spicyspiderhp = Math.Max(0, spicyspiderhp);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($" you did {Playerdamage} to Spicy Spider");
            Console.ResetColor();

            int enemydamage = Random.Shared.Next(20);
            playerhp -= enemydamage;
            playerhp = Math.Max(0, playerhp);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"Spicy Spider did {enemydamage} to you");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"You: {playerhp} Spicy Spider: {spicyspiderhp}");
            Console.ResetColor();

            Console.WriteLine("Continue");
            Console.ReadLine();
            Console.Clear();
        }

        if (playerhp <= 0)
    {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("You died! Want to try again or fight Rolling rat? (1/2)");
            Console.ResetColor();
            string retry = Console.ReadLine().ToLower();

            if (retry == "1")
            {
                playerhp = playerhpmax;
                continue;
            }
            else if (retry == "2")
            {
                Environment.Exit(0);
            }
    }

        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("Fight again (Reward)     or     Go against the Trembling Troll     (1/2)");
        string Choice = Console.ReadLine();
        Console.Clear();
        Console.ResetColor();

        if (Choice == "1")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("You gained +250hp  +50dmg as a reward!");
                Console.Clear();
                Console.ResetColor();

                playerhpmax += 250;
                playerdamage += 50;
                playerhp = playerhpmax;
                spicyspiderhp = 250;

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
                spicyspiderfight = false;
                tremblingtrollfight = true;
                playerhp = playerhpmax;
            } 
        }
    }

    spiderfight(ref playerhp, ref playerhpmax, ref playerdamage);
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

    if (changemind == "y")
    {
        enterdung = true;
        answer = "y";
    }
    else if (changemind == "y")
        {
            enterdung = false;
            Environment.Exit(500);
        }
    }



}




Console.ReadLine();
