// Slump

Random generator = new Random();
// behöver bara en generator

int hitRoll = generator.Next(100);
Console.WriteLine(hitRoll);

hitRoll = generator.Next(100);
Console.WriteLine(hitRoll);

if (hitRoll > 95)
{
    Console.WriteLine("Crit!");
}
else if (hitRoll > 40)
{
    Console.WriteLine("HIT!");
}
else 
{
    Console.WriteLine("Miss!");
}


Console.ReadLine();


// Loopar

