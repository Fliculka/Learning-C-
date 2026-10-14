/*
Random rnd = new Random();
int randomnumb = rnd.Next(1, 100);
Console.WriteLine(randomnumb);
*/
Random kostka = new Random();
Random Cislo = new Random();
int cisloTOBeat = Cislo.Next(10, 100);


PrintBlue("Vítejte ve hře!");
PrintBlue("Hráč 1 - jméno)");
string player1name = Console.ReadLine();
Player player1 = new Player();
player1.name = player1name;


PrintBlue("Hráč 2 - jméno)");
string player2name = Console.ReadLine();
Player player2 = new Player();
player2.name = player2name;

while (true)
{
    for (int i = 0; i < 1; i++)
    {
        PrintBlue($"{player1.name} hází kostkou (stiskněte SpaceBar)");
        bool spacebar = Console.ReadKey().Key == ConsoleKey.Spacebar;
        if (spacebar)
        {
            Console.Clear();
            int randomnumb = kostka.Next(1, 7);
            player1.number = player1.number + randomnumb;
            Console.WriteLine($"{player1name} hodil číslo: {randomnumb} a má {player1.number} bodů");
            spacebar = false;
            i = 0;
            if (player1.number >= cisloTOBeat)
            {
                Console.WriteLine($"{player1.name} vyhrál/a!");
                break;
            }
            break;
        }
    }
    for (int i = 0; i < 1; i++)
    {
        PrintBlue($"{player2name} hází kostkou (stiskněte SpaceBar)");
        bool spacebar2 = Console.ReadKey().Key == ConsoleKey.Spacebar;
        if (spacebar2)
        {
            Console.Clear();
            int randomnumb = kostka.Next(1, 7);
            player2.number = player2.number + randomnumb;
            Console.WriteLine($"{player2name} hodil číslo: {randomnumb} a má {player2.number} bodů");
            spacebar2 = false;
            i = 0;
            if (player2.number >= cisloTOBeat)
            {
                Console.WriteLine($"{player2.name} vyhrál/a!");
                break;
            }
        }
    }
}


static void PrintBlue(string text)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine(text);
    Console.ResetColor();
}

class Player
{

    public string name;
    public int number;
}
