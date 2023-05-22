namespace Pokemon;

// Pokemon-related classes

public abstract class Pokemon
{
    private string name;

    public string Name { get { return name; } set { name = value; } }

    public Pokemon(string name)
    {
        this.name = name;
    }

    public abstract void UseBattleCry(string pokemonName);
}


public class Charmander : Pokemon
{
    private const string strength = "fire";
    private const string weakness = "water";

    public Charmander(string name) : base(name) { }

    public override void UseBattleCry(string pokemonName)
    {
        Console.Write(pokemonName + " uses it's battle cry: \"");
        for (int i = 0; i < 10; i++)
        {
            if (pokemonName != "") { Console.Write(pokemonName + "! "); }
            else { Console.Write("Charmander! "); }
        }
        Console.WriteLine("\"");
    }
}


public class Squirtle : Pokemon
{
    private const string strength = "water";
    private const string weakness = "grass";

    public Squirtle(string name) : base(name) { }

    public override void UseBattleCry(string pokemonName)
    {
        Console.Write(pokemonName + " uses it's battle cry: \"");
        for (int i = 0; i < 10; i++)
        {
            if (pokemonName != "") { Console.Write(pokemonName + "! "); }
            else { Console.Write("Squirtle! "); }
        }
        Console.WriteLine("\"");
    }
}


public class Bulbasaur : Pokemon
{
    private const string strength = "grass";
    private const string weakness = "fire";

    public Bulbasaur(string name) : base(name) { }

    public override void UseBattleCry(string pokemonName)
    {
        Console.Write(pokemonName + " uses it's battle cry: \"");
        for (int i = 0; i < 10; i++)
        {
            if (pokemonName != "") { Console.Write(pokemonName + "! "); }
            else { Console.Write("Bulbasaur! "); }
        }
        Console.WriteLine("\"");
    }
}