namespace Pokemon;

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
            if (i > 0) { Console.Write(" "); }

            if (pokemonName != "") { Console.Write(pokemonName + "!"); }
            else { Console.Write("Bulbasaur!"); }
        }
        Console.WriteLine("\"");
    }
}
