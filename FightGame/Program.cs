// Slump

Random generator = new Random();
// behöver bara en generator

Console.CursorVisible = false;

static void Close()
{
    Console.ReadKey();
    Environment.Exit(0);
}

Console.WriteLine("You are fighting some guy. You both have 10 hp.");

Console.ReadLine();

int hp = 10;
int hpOpponent = 10;

Console.WriteLine("You will start the round. Press [enter] to start");
Console.ReadLine();

while (hp >= 0 && hpOpponent >= 0)
{
    int hitRoll = generator.Next(10);
    int hitRoll2 = generator.Next(10);

    hpOpponent -= hitRoll;
    Console.WriteLine($"You hit with {hitRoll} damage");

    hp -= hitRoll2;
    Console.WriteLine($"You get hit with {hitRoll2} damage");
}

if (hp < 0)
{
    Console.WriteLine("You lost");
    Console.ReadLine();
    Close();
}
else
{
    Console.WriteLine("You win");
    Console.ReadLine();
    Close();
}