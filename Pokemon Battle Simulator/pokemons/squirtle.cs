namespace Pokemon;

public class Squirtle : Pokemon
{
    public Squirtle(string name, string strength = "water", string weakness = "grass") : base(name, strength, weakness) { }

    public override void UseBattleCry(string pokemonName)
    {
        Console.Write(pokemonName + " uses it's battle cry: \"");
        for (int i = 0; i < 10; i++)
        {
            if (i > 0) { Console.Write(" "); }

            if (pokemonName != "") { Console.Write(pokemonName + "!"); }
            else { Console.Write("Squirtle!"); }
        }
        Console.WriteLine("\"");
    }
}
