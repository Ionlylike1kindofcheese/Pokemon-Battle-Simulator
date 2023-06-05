﻿namespace Pokemon;

public class Charmander : Pokemon
{
    public Charmander(string name, string strength = "fire", string weakness = "water") : base(name, strength, weakness) { }

    public override void UseBattleCry(string pokemonName)
    {
        Console.Write(pokemonName + " uses it's battle cry: \"");
        if (pokemonName != "") { Console.Write(pokemonName + "!"); }
        else { Console.Write("Charmander!"); }
        Console.WriteLine("\"");
    }
}
