using System.Formats.Asn1;
using System.Runtime.CompilerServices;

Player player = new();
Enemy enemy = new();
Console.WriteLine("Hej vad är ditt namn?");
player.Name = Console.ReadLine();
while (true)
{
    while (enemy.HP > 0)
    {
        Console.WriteLine("tryck enter för att slå");
        Console.ReadLine();
        enemy.HP -= player.attack;
        Console.WriteLine("enemy har " + enemy.HP + " HP kvar");
    }
    bool active = true;
    while (active)
    {
        Console.WriteLine("vill du köra igen? Y/N");
        string answer = Console.ReadLine().ToUpper();

        if (answer == "Y" || answer == "YES")
        {
            active = false;
        }
        if (answer == "N" || answer == "NO")
        {
            return;
        }
    }
}