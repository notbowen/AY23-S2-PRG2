namespace Pokemon_S10255800;

public class Pokemon
{
    // Modifier table, used to calculate damage
    private static readonly Dictionary<string, Dictionary<string, double>> Modifier =
        new Dictionary<string, Dictionary<string, double>>()
        {
            { "Grass", new Dictionary<string, double>() { { "Grass", 1.0 }, { "Fire", 0.5 }, { "Water", 2.0 } } },
            { "Fire", new Dictionary<string, double>() { { "Grass", 2.0 }, { "Fire", 1.0 }, { "Water", 0.5 } } },
            { "Water", new Dictionary<string, double>() { { "Grass", 2.0 }, { "Fire", 0.5 }, { "Water", 1.0 } } }
        };

    // Public variables
    public int Id { get; }
    public string Name { get; }
    public string P_type { get; }
    public int Power { get; }
    public int Hp { get; private set; }
    public int Attack { get; }
    public int Defense { get; }

    // Constructor class
    public Pokemon(int id, string name, string p_type, int power, int hp, int attack, int defense)
    {
        Id = id;
        Name = name;
        P_type = p_type;
        Power = power;
        Hp = hp;
        Attack = attack;
        Defense = defense;
    }

    // Q6)
    public bool Hit(Pokemon defender)
    {
        // i)
        if (defender == this)
        {
            Console.WriteLine("Attacker and Defender cannot be the same Pokemon.");
            return false;
        }

        // ii)
        if (Hp == 0)
        {
            Console.WriteLine("Attacker is unable to attack.");
            return false;
        }

        // iii)
        if (defender.Hp == 0)
        {
            Console.WriteLine("Defender already has 0 HP.");
            return false;
        }

        // Calculate damage
        int damage = (int)Math.Floor(0.5 * Power * (Attack / (double)defender.Defense) *
                                     Modifier[P_type][defender.P_type]);

        // iv)
        Console.WriteLine("Previous HP of the Defender (before the attack): {0}", defender.Hp);
        Console.WriteLine("Damage of the Attacker: {0}", damage);

        // v)
        defender.Hp = Math.Max(defender.Hp - damage, 0);

        // vi)
        Console.WriteLine("Updated HP of the Defender (after the attack): {0}", defender.Hp);
        return true;
    }
}