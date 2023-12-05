// Pokemon
// Date: 29 Nov 2023
// Written by: Hu Bowen

using Pokemon_S10255800;

// Q2
// Uses a list as it is the easiest to add to and search
List<Pokemon> pokemons = new List<Pokemon>();

// Q3
void InitialisePokemonCollection()
{
    using (StreamReader sr = File.OpenText("pokemon.csv"))
    {
        string? line = sr.ReadLine(); // Skip header
        while ((line = sr.ReadLine()) != null) // Read till end of file
        {
            string[] data = line.Split(',');
            Pokemon pokemon = new Pokemon(
                int.Parse(data[0]),
                data[1],
                data[2],
                int.Parse(data[3]),
                int.Parse(data[4]),
                int.Parse(data[5]),
                int.Parse(data[6])
            );
            pokemons.Add(pokemon);
        }
    }
}

InitialisePokemonCollection();

// Q4
void DisplayOutput()
{
    Console.WriteLine("{0,-5} {1,-20} {2,-10} {3,-10} {4,-10} {5,-10} {6}", "ID", "Name", "Type", "Power", "HP",
        "Attack", "Defense");
    foreach (Pokemon pokemon in pokemons)
    {
        Console.WriteLine("{0,-5} {1,-20} {2,-10} {3,-10} {4,-10} {5,-10} {6}", pokemon.Id, pokemon.Name,
            pokemon.P_type, pokemon.Power, pokemon.Hp, pokemon.Attack, pokemon.Defense);
    }
}

// Q5
void ProcessHit()
{
    // i)
    Console.Write("Enter Attacker Pokemon ID: ");
    int attackerId = int.Parse(Console.ReadLine()!);  // ! is used to suppress IDE warning :(

    // ii)
    Pokemon? attacker = pokemons.FirstOrDefault(p => p.Id == attackerId);
    if (attacker == null)
    {
        Console.WriteLine("Attacker Pokemon ID not found.");
        return;
    }

    // iii)
    Console.Write("Enter Defender Pokemon ID: ");
    int defenderId = int.Parse(Console.ReadLine()!);  // ! is used to suppress IDE warning :(

    // iv)
    Pokemon? defender = pokemons.FirstOrDefault(p => p.Id == defenderId);
    if (defender == null)
    {
        Console.WriteLine("Defender Pokemon ID not found.");
        return;
    }

    // v)
    attacker.Hit(defender);
}

// Q7)
while (true)
{
    DisplayOutput();
    ProcessHit();
    Console.WriteLine();
}