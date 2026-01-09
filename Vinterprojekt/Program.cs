using System;
using System.Threading;



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
        bool spicyspiderfight = false;
        bool tremblingtrollfight = false;

        while (rollingratfight)
        {
            rollingrathp = 50;
            while (playerhp > 0 && rollingrathp > 0)
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

        while (spicyspiderfight)
        {
            spicyspiderhp = 250;
            while (playerhp > 0 && spicyspiderhp > 0)
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
                    rollingratfight = true;
                    spicyspiderfight = false;
                    playerhp = playerhpmax;
                    break;
                }
            }

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Fight again (Reward)     or     Go against the Trembling Troll     (1/2)");
            string Choice2 = Console.ReadLine();
            Console.Clear();
            Console.ResetColor();

            if (Choice2 == "1")
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
            else if (Choice2 == "2")
            {
                spicyspiderfight = false;
                tremblingtrollfight = true;
                playerhp = playerhpmax;
            }
        }

        while (tremblingtrollfight)
        {
            tremblingtrollhp = 1000;
            while (playerhp > 0 && tremblingtrollhp > 0)
            {
                int Playerdamage = Random.Shared.Next(playerdamage);
                tremblingtrollhp -= Playerdamage;
                tremblingtrollhp = Math.Max(0, tremblingtrollhp);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($" you did {Playerdamage} to Trembling Troll");
                Console.ResetColor();

                int enemydamage = Random.Shared.Next(50);
                playerhp -= enemydamage;
                playerhp = Math.Max(0, playerhp);
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"Trembling Troll did {enemydamage} to you");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"You: {playerhp} Trembling Troll: {tremblingtrollhp}");
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
                    spicyspiderfight = true;
                    tremblingtrollfight = false;
                    playerhp = playerhpmax;
                    break;
                }
            }

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Fight again (Reward)     or     Finish the Dungeon     (1/2)");
            string Choice3 = Console.ReadLine();
            Console.Clear();
            Console.ResetColor();

            if (Choice3 == "1")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("You gained +500hp  +100dmg as a reward!");
                Console.Clear();
                Console.ResetColor();

                playerhpmax += 500;
                playerdamage += 100;
                playerhp = playerhpmax;
                tremblingtrollhp = 1000;

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
            else if (Choice3 == "2")
            {
                tremblingtrollfight = false;
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Congratulations! You have cleared the dungeon!");
                Console.ResetColor();
                Thread.Sleep(2000);
                Environment.Exit(0);
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

        if (changemind == "y")
        {
            enterdung = true;
            answer = "y";
        }
        else
        {
            enterdung = false;
            Environment.Exit(500);
        }
    }
}

Console.ReadLine();