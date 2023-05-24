namespace Pokemon;

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
            if (i > 0) { Console.Write(" "); }

            if (pokemonName != "") { Console.Write(pokemonName + "!"); }
            else { Console.Write("Charmander!"); }
        }
        Console.WriteLine("\"");
    }
}
