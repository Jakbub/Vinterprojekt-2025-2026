using System;
using System.Threading;

static void run()
{
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

string answer = Console.ReadLine();


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

        int stage = 1;

        while (true)
        {
            //rollingrat fight
            if (stage == 1)
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

                Console.WriteLine("1 = Fight Again, 2 = Go to Spicy Spider");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("Ward: You grow stronger from the battle...");
                    Console.ResetColor();

                    Console.WriteLine("+50 HP  +15 Damage");

                    playerhpmax += 50;
                    playerdamage += 15;
                    playerhp = playerhpmax;

                    Thread.Sleep(1500);
                    Console.Clear();
                }
                else if (choice == "2")
                {
                    stage = 2;
                    playerhp = playerhpmax;

                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("Ward: Deeper you go...");
                    Console.ResetColor();

                    Thread.Sleep(1500);
                    Console.Clear();
                    continue;
                }
            }

            //spicyspiderfight
            else if (stage == 2)
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

                    int enemydamage = Random.Shared.Next(40);
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

                Console.WriteLine("1 = Fight Again, 2 = Back to Rat, 3 = Troll");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("Ward: The spider's venom strengthens you...");
                    Console.ResetColor();

                    Console.WriteLine("+120 HP  +25 Damage");

                    playerhpmax += 120;
                    playerdamage += 25;
                    playerhp = playerhpmax;

                    Thread.Sleep(1500);
                    Console.Clear();
                }
                else if (choice == "2")
                {
                    stage = 1;
                    playerhp = playerhpmax;

                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("Ward: You retreat...");
                    Console.ResetColor();

                    Thread.Sleep(1500);
                    Console.Clear();
                    continue;
                }
                else if (choice == "3")
                {
                    stage = 3;
                    playerhp = playerhpmax;

                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("Ward: A terrifying presence awaits...");
                    Console.ResetColor();

                    Thread.Sleep(1500);
                    Console.Clear();
                    continue;
                }
            }

            //tremblingtrollfight
            else if (stage == 3)
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

                    int enemydamage = Random.Shared.Next(75);
                    playerhp -= enemydamage;
                    playerhp = Math.Max(0, playerhp);
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine($"Trembling troll did {enemydamage} to you");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine($"You: {playerhp} Trembling troll: {tremblingtrollhp}");
                    Console.ResetColor();

                    Console.WriteLine("Continue");
                    Console.ReadLine();
                    Console.Clear();
                }

                if (playerhp <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("Ward: Even the strongest fall...");
                    Console.ResetColor();

                    Console.WriteLine("1 = Retry, 2 = Back to Spider");
                    string c = Console.ReadLine();

                    if (c == "1")
                    {
                        playerhp = playerhpmax;
                        continue;
                    }
                    else
                    {
                        stage = 2;
                        playerhp = playerhpmax;
                        continue;
                    }
                }

                Console.WriteLine("1 = Fight Again, 2 = Finish");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("Ward: You feel unstoppable...");
                    Console.ResetColor();

                    Console.WriteLine("+500 HP  +100 Damage");

                    playerhpmax += 500;
                    playerdamage += 100;
                    playerhp = playerhpmax;

                    Thread.Sleep(1500);
                    Console.Clear();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("Ward: You have conquered the dungeon...");
                    Thread.Sleep(1500);
                    Console.Clear();
                    Console.ResetColor();
                    break;
                }
            }
        }
    }
}

run();